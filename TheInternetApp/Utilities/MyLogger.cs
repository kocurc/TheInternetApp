﻿using NLog;

namespace TheInternetApp.Utilities;

public class MyLogger : ILogger
{
    private static MyLogger? _instance;
    private static Logger? _logger;

    private MyLogger() { }

    public static MyLogger GetInstance()
    {
        // ReSharper disable once ConvertIfStatementToNullCoalescingExpression
        if (_instance == null)
        {
            _instance = new MyLogger();
        }

        return _instance;
    }

    private static Logger GetLogger(string logger)
    {
        return MyLogger._logger ?? (MyLogger._logger = LogManager.GetLogger(logger));
    }

    public void Debug(string message, string? arg = null)
    {
        if (arg == null)
        {
            GetLogger("myAppLoggerRules").Debug(message);
        }
        else
        {
            GetLogger("myAppLoggerRules").Debug(message, arg);
        }
    }

    public void Info(string message, string? arg = null)
    {
        if (arg == null)
        {
            GetLogger("myAppLoggerRules").Info(message);
        }
        else
        {
            GetLogger("myAppLoggerRules").Info(message, arg);
        }
    }

    public void Warning(string message, string? arg = null)
    {
        if (arg == null)
        {
            GetLogger("myAppLoggerRules").Warn(message);
        }
        else
        {
            GetLogger("myAppLoggerRules").Warn(message, arg);
        }
    }

    public void Error(string message, string? arg = null)
    {
        if (arg == null)
        {
            GetLogger("myAppLoggerRules").Error(message);
        }
        else
        {
            GetLogger("myAppLoggerRules").Error(message, arg);
        }
    }
}

