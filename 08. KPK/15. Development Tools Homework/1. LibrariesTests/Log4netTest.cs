namespace LibrariesTests
{
    using System;
    using System.Linq;
    using log4net;

    class Log4netTest
    {
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(string));
            log.Error("This is an example of a log message");
        }
    }
}
