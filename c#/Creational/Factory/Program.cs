using Factory.FactoryNotification;

public class Program
{
    static void Main()
    {
        string articleMessage = "Your article has been successfully publisher";
        string notificationType = "EMAIL";

        var notification = CreateNotification.Create(notificationType);

        notification.Send(articleMessage);
    }
}
