namespace Module
{
    public class ModuleMessage
    {
        public String Source { get; set; }
        public string Target { get; set; }
        public string MessageType { get; set; }
        public Object Payload { get; set; }

        public ModuleMessage(string source, string target, string messageType, object payload)
        {
            Source = source;
            Target = target;
            MessageType = messageType;
            Payload = payload;
        }
    }
}