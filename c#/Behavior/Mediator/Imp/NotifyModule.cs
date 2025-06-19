using Module;

namespace Imp
{
    public class NotifyModule : AbstractModule
    {
        public static readonly string MODULE_NAME = "Notification";
        public const string OPERATION_NOTIFY = "Notify";

        public override String GetModuleName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_NOTIFY:
                    return Notify(message);
                default:
                    throw new SystemException($"Unknown message type: {message.MessageType}");
            }
        }

        public object Notify(ModuleMessage message)
        {
            Console.WriteLine($"Notification sent: {message.Payload}");
            return null;  
        }
    }
}