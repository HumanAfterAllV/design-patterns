namespace Models
{
    public abstract class Contributor
    {
        public string? Name { get; set; }
        public string? Rfc { get; set; }
        public Status Status { get; set; }
        
        public Address? Address { get; set; }
        public Telephone? Telephone { get; set; }
        public CreditData? CreditData { get; set; }
    }
}