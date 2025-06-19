namespace Module
{
    public abstract class AbstractModule
    {
        protected ModuleMediator? Mediator;

        public abstract string GetModuleName();

        public void Activate()
        {
            Mediator = ModuleMediator.GetInstance();
            Mediator.RegisterModule(this);
        }

        public abstract Object NotifyMessage(ModuleMessage message);
    }
}