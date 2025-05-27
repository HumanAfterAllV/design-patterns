using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Interface.IMessage;
using Decorators;

namespace Decorators
{
    public class EncryptMessage : MessageDecorator
    {
        private readonly string password;

        public EncryptMessage(string password, IMessage message) : base(message)
        {
            this.password = password;
        }

        public IMessage Encrypt()
        {
            try
            {
                //1. Obtener el texto plano
                var plainText = Encoding.UTF8.GetBytes(this.message.GetContent());

                // 2.  Generar salt
                var salt = new byte[12];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }

                //3. Derivar clave con PBKDF2
                var key = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256).GetBytes(32);

                //4. Crear cifrador AES-CCM
                using var aes = new AesCcm(key);
                var nonce = salt; //Usamos el salt como nonce (12 bytes)
                var ciphertext = new byte[plainText.Length];
                var tag = new byte[16];

                aes.Encrypt(nonce, plainText, ciphertext, tag);

                //5. Concatenar salt + tag + ciphertext
                var encryptData = new byte[salt.Length + tag.Length + ciphertext.Length];
                Buffer.BlockCopy(salt, 0, encryptData, 0, salt.Length);
                Buffer.BlockCopy(tag, 0, encryptData, salt.Length, tag.Length);
                Buffer.BlockCopy(ciphertext, 0, encryptData, salt.Length + tag.Length, ciphertext.Length);

                //6. Codificar en base64
                var encryptB64 = Convert.ToBase64String(encryptData);
                this.message.SetContent(encryptB64);
                
                return this.message;

            }
            catch (Exception ex)
            {
                throw new Exception("Encryption failed: " + ex.Message);
            }
        }

        public override IMessage ProcessMessage()
        {
            this.message = this.message.ProcessMessage();
            return this.Encrypt();
        }
        
    }
}