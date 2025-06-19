namespace Creational.Singleton
{
    public class Program
    {
        public enum Type
        {
            Info,
            Description,
            Error
        }

        public class Logger
        {
            private static readonly Logger _instance = new Logger();
            private readonly List<string> logList = new List<string>();

            private Logger()
            {
                
            }

            public static Logger Instance => _instance;

            public void AddLog(string message, Type type)
            {
                DateTime now = DateTime.Now;
                logList.Add($"[{now.ToShortTimeString()}: {message} - {type}]");
            }

            public List<string> GetLogs()
            {
                return logList;
            }
        }

        static void Main()
        {
            var logger = Logger.Instance;

            logger.AddLog("Hello, this is a message", Type.Info);
            logger.AddLog("Goodbye", Type.Description);
            logger.AddLog("Hello, this is a second message", Type.Info);
            logger.AddLog("May the force by with you", Type.Description);

            foreach (var log in logger.GetLogs())
            {
                Console.WriteLine(log);
            }
        }
    }
}