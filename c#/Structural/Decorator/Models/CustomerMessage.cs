using Interface.IMessage;

namespace Models.CustomerMessage
{
    public class CustomerMessage : IMessage
    {
        protected string name;
        protected string email;
        protected int telephone;

        public CustomerMessage(string name, string email, int telephone)
        {
            this.name = name;
            this.email = email;
            this.telephone = telephone;
        }

        public override string ToString()
        {
            return $"Name {this.name} Email: {this.email} Telephone: {this.telephone}";
        }

        public IMessage ProcessMessage()
        {
            return this;
        }

        public string GetContent()
        {
            return this.ToString();
        }

        public void SetContent(string content)
        {
            throw new Exception("Not supported yet.");
        }
    }
}