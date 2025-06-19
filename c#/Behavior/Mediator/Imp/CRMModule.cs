using Dto;
using Module;

namespace Imp
{
    public class CRMModule : AbstractModule
    {
        public static readonly string MODULE_NAME = "CRMModule";
        public const string OPERATION_CREATE_ORDER = "CreateOrder";

        public override string GetModuleName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_CREATE_ORDER:
                    return CreateSaleOrder(message);
                default:
                    throw new SystemException($"Unknown message type: {message.MessageType}");
            }
        }

        public void StartThread(SalesOrder salesOrder)
        {
            try
            {
                Thread.Sleep(1000 * 10);
                ModuleMessage message = new ModuleMessage(MODULE_NAME, EccomerceModule.MODULE_NAME, EccomerceModule.OPERATION_COMPLETE_ORDER, salesOrder);
                Mediator.Mediate(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in thread: {ex.Message}");
            }
        }

        private string CreateSaleOrder(ModuleMessage message)
        {
            Sale sale = (Sale)message.Payload;
            string ID = System.Guid.NewGuid().ToString();

            Console.WriteLine("Sales order successfully created");
            SalesOrder salesOrder = new SalesOrder(ID);
            salesOrder.Products = sale.Products;

            ModuleMessage stockEvent = new ModuleMessage(MODULE_NAME, StockModule.MODULE_NAME, StockModule.OPERATION_DECREMENT_STOCK, salesOrder);
            Mediator.Mediate(stockEvent);

            Thread thread = new Thread(() => StartThread(salesOrder));
            thread.Start();

            return ID;
        }
        
    }
}