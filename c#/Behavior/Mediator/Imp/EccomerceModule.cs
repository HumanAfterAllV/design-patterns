using Dto;
using Module;

namespace Imp
{
    public class EccomerceModule : AbstractModule
    {
        public static string MODULE_NAME = "EcommerceModule";
        public const string OPERATION_COMPLETE_ORDER = "CompleteOrder";

        public override string GetModuleName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_COMPLETE_ORDER:
                    return CompleteOrder(message);
                default:
                    throw new SystemException($"Unknown message type: {message.MessageType}");
            }
        }

        public String CompleteOrder(ModuleMessage message)
        {
            SalesOrder salesOrder = (SalesOrder)message.Payload;
            Console.WriteLine($"Order completed successfully: {salesOrder.Id}");

            ModuleMessage crmMessage = new ModuleMessage(MODULE_NAME, NotifyModule.MODULE_NAME, NotifyModule.OPERATION_NOTIFY, salesOrder);
            Mediator.Mediate(crmMessage);
            return salesOrder.Id;
        }

        public String CreateSale(Sale sale)
        {
            ModuleMessage crmMessage = new ModuleMessage(MODULE_NAME, CRMModule.MODULE_NAME, CRMModule.OPERATION_CREATE_ORDER, sale);
            return Mediator.Mediate(crmMessage).ToString();
             
        }
    }
}