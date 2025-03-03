using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    // ILogger interface
    public interface ILogger
    {
        void Log(string message);
    }

    // FileLogger class
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log to file: {message}");
        }
    }

    // Abstract decorator class
    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void Log(string message)
        {
            _logger.Log(message);
        }
    }

    // TimestampDecorator class
    public class TimestampDecorator : LoggerDecorator
    {
        public TimestampDecorator(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            message = $"[{DateTime.Now}] {message}";
            base.Log(message);
        }
    }

    // ErrorCategoryDecorator class
    public class ErrorCategoryDecorator : LoggerDecorator
    {
        public ErrorCategoryDecorator(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            message = $"[Error] {message}";
            base.Log(message);
        }
    }

}
