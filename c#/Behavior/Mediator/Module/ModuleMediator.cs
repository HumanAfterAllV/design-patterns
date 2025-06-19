namespace Module
{
    public class ModuleMediator
    {
        private static ModuleMediator? Mediator;
        private static readonly Dictionary<String, AbstractModule> Modules = new Dictionary<string, AbstractModule>();

        private ModuleMediator()
        {
            // Singleton constructor
        }
        public static ModuleMediator GetInstance()
        {
            if (Mediator == null)
            {
                Mediator = new ModuleMediator();
            }

            return Mediator;
        }

        public void RegisterModule(AbstractModule module)
        {
            Modules.Add(module.GetModuleName(), module);
        }

        public Object Mediate(ModuleMessage mediateEvent)
        {
            if (!Modules.ContainsKey(mediateEvent.Target))
            {
                throw new AbandonedMutexException($"Module {mediateEvent.Target} not found");
            }
            
            Console.WriteLine("Mediate source > '" + mediateEvent.Source
                + "', target > '" + mediateEvent.Target
                + "', messagetType > '"+mediateEvent.MessageType+"'");
            AbstractModule module = Modules[mediateEvent.Target];
            return module.NotifyMessage(mediateEvent);
        }

    }
}