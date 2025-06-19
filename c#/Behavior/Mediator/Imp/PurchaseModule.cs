using Module;

namespace Imp
{
    public class PurchaseModule : AbstractModule
    {
        public static readonly string MODULE_NAME = "PurchaseModule";
        public const string OPERATION_PURCHASE_REQUEST = "PurchaseRequest";

        public override string GetModuleName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_PURCHASE_REQUEST:
                    return ProcessPurchaseRequest(message);
                default:
                    throw new SystemException($"Unknown message type: {message.MessageType}");
            }
        }

        private object ProcessPurchaseRequest(ModuleMessage message)
        {
            return null;
        }
    }
}