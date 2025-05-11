
from decorators.message_decorator import MessageDecorator
from message.message import IMessage

from Crypto.Cipher import AES
from Crypto.Hash import SHA256
from Crypto.Protocol.KDF import PBKDF2
from Crypto.Random import get_random_bytes

import base64

class EncryptMessage(MessageDecorator):
    def __init__(self, user: str, password: str, message: IMessage):
        self.user = user
        self.password = password
        super().__init__(message)

    def encrypt_message(self) -> 'IMessage':
        try:
            #1. Obtener el contenido
            plaintext = self.message.get_content().encode('utf-8')

            #2. Derivar una clave segura (256 bits)
            salt = get_random_bytes(16)
            key = PBKDF2(self.password, salt, dkLen=32, count=100_000, hmac_hash_module=SHA256)

            #3. Crear el cifrado con AES en modo EAX
            cipher = AES.new(key, AES.MODE_EAX)
            nonce = cipher.nonce
            ciphertext, tag = cipher.encrypt_and_digest(plaintext)


            #4. Empaquetar todo (salt + nonce + tag + ciphertext) y pasarlo a base64
            encrypt_data = salt + nonce + tag + ciphertext
            encrypt_b64 = base64.b64encode(encrypt_data).decode('utf-8')

            #5. Guardar el contenido en un decorador
            self.set_content(encrypt_b64)

            return self.message

        except Exception as error:
            raise RuntimeError("Encrypted failed.") from error
        
    def process_message(self) -> 'IMessage':
        self.message = self.message.process_message()
        return self.encrypt_message()
    

        


    

                