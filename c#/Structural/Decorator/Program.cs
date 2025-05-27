using Models.TextMessage;
using Decorators;

public class Program
{
    public static void Main(string[] args)
    {
        var message = new TextMessage("Este es un mensaje");
        Console.WriteLine($"Mensaje Original: {message.GetContent()}");

        var password = "superclave123";

        var messageEncrypt = new EncryptMessage(password, message);
        var result = messageEncrypt.ProcessMessage();

        Console.WriteLine($"Mensaje encriptado: {result.GetContent()}");

    }
}