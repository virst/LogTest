using NLog;

namespace LogTest
{
    public static class Log
    {

        public static readonly NLog.Logger Logger;

        static Log()
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "${basedir}/Logs/log_${date:format=yyyy-MM-dd}.log" };
            var errorlogfile = new NLog.Targets.FileTarget("errorlogfile") { FileName = "${basedir}/Logs/err_${date:format=yyyy-MM-dd}.log" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Error, LogLevel.Fatal, errorlogfile);

            // Apply config           
            NLog.LogManager.Configuration = config;

            Logger = NLog.LogManager.GetCurrentClassLogger();

        }
    }
}
