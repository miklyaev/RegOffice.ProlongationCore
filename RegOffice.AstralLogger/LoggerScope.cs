using Serilog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.AstralLogger
{
    public interface ILoggerScope : IDisposable
    {
        ILoggerScope With<T>(string name, T value);
    }

    public sealed class LoggerScope : ILoggerScope
    {
        private readonly List<IDisposable> _serilogScopes = new List<IDisposable>();

        public ILoggerScope With<T>(string name, T value)
        {
            _serilogScopes.Add(LogContext.PushProperty(name, value));
            return this;
        }
        public void Dispose()
        {
            _serilogScopes.Reverse();
            _serilogScopes.ForEach(x => x.Dispose());
            _serilogScopes.Clear();
        }
    }
}
