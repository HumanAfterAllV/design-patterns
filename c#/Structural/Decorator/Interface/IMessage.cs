namespace Interface.IMessage
{
    public interface IMessage
    {
        public IMessage ProcessMessage();
        public string GetContent();
        public void SetContent(string content);
    }
}