namespace Dto
{
    public class SalesOrder : Sale
    {
        public string Id { get; set; }

        public SalesOrder(string id)
        {
            Id = id;
        }
    }
}