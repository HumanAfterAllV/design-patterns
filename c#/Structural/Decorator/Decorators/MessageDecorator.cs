using Interface.IMessage;

namespace Decorators
{
    public class MessageDecorator : IMessage
    {
        protected IMessage message;

        public MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public virtual IMessage ProcessMessage()
        {
            return this.message.ProcessMessage();
        }

        public string GetContent()
        {
            return this.message.GetContent();
        }

        public void SetContent(string content)
        {
            this.message.SetContent(content);
        }
    }
}