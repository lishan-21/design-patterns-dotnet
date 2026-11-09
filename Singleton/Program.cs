namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLogger logger = MyLogger.GetInstance();
            logger.Log("Before Set Directory: " + logger.Directory);
            logger.Directory = "C:\\Logs";
            logger.Log("After Set Directory, This is a log message.");
            MyLogger loggerNew = MyLogger.GetInstance();
            loggerNew.Log("This is another log message.");
        }
    }
}
