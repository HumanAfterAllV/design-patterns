from message.text_message import TextMessage
from decorators.encrypt_message import EncryptMessage

def main():
    # Mensaje original
    mensaje = TextMessage("Este es un mensaje secreto.")
    print("Mensaje original:", mensaje.get_content())

    # Decorador de encriptación
    usuario = "camarada"
    contraseña = "superclave123"

    mensaje_encriptado = EncryptMessage(usuario, contraseña, mensaje)
    resultado = mensaje_encriptado.process_message()

    print("Mensaje encriptado:", resultado.get_content())

if __name__ == "__main__":
    main()
