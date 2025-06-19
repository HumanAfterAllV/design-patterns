using Dto;
using Module;

namespace Imp
{
    public class StockModule : AbstractModule
    {
        public static readonly string MODULE_NAME = "StockModule";
        public const string OPERATION_DECREMENT_STOCK = "DecrementStock";

        public override string GetModuleName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_DECREMENT_STOCK:
                    return DecrementStock(message);
                default:
                    throw new SystemException($"Unknown message type: {message.MessageType}");
            }
        }

        private string DecrementStock(ModuleMessage message)
        {
            SalesOrder salesOrder = (SalesOrder)message.Payload;
            foreach (var product in salesOrder.Products)
            {
                Console.WriteLine($"Decrementing stock for product: {product.Name}");
            }

            ProductRequest productRequest = new ProductRequest();
            productRequest.Products = salesOrder.Products;

            ModuleMessage purchaseMessage = new ModuleMessage(MODULE_NAME, PurchaseModule.MODULE_NAME, PurchaseModule.OPERATION_PURCHASE_REQUEST, productRequest);
            Mediator.Mediate(purchaseMessage);
            return null;
        }
    }
}