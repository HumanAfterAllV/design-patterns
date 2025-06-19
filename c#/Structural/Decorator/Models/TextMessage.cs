using Interface.IMessage;

namespace Models.TextMessage
{
    public class TextMessage : IMessage
    {
        protected string content;

        public TextMessage(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return this.content;
        }

        public IMessage ProcessMessage()
        {
            return this;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }
    }

}
