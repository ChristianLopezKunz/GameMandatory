using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.TraceLogger
{
    /// <summary>
    /// Logger klassen er en singleton klasse, som bruges til at trace & logge.
    /// </summary>
    public class Logger
    {
        //Singleton
        private static readonly Logger instance = new Logger();
        public static Logger Instance
        {
            get { return instance; }
        }
        
        /// <summary>
        /// Tracesource giver adgang til at kunne logge
        /// </summary>
        private static TraceSource _traceSource;

        /// <summary>
        /// Her initialser jeg tracesource og tilføjer listeners
        /// </summary>
        static Logger()
        {
            _traceSource = new TraceSource("Logger");
            _traceSource.Switch = new SourceSwitch("LoggerSwitch", "All");
            _traceSource.Listeners.Add(new ConsoleTraceListener());
            _traceSource.Listeners.Add(new TextWriterTraceListener(new StreamWriter(@"C:\Users\chr_k\Desktop\Opgaver\Valgfag c#\Mandatory assignment\GameMandatory\GameMandatory\bin\Debug\net7.0\TracingLog.txt") { AutoFlush = true }));
        }

        private Logger() { }

        /// <summary>
        /// Metode til at kunne lave custom listeners
        /// </summary>
        /// <param name="listener"></param>
        public static void AddListener(TraceListener listener)
        {
            _traceSource.Listeners.Add(listener);
        }

        /// <summary>
        /// Metode til at kunne fjerne custom listeners
        /// </summary>
        /// <param name="listener"></param>
        public static void RemoveListener(TraceListener listener)
        {
            _traceSource.Listeners.Remove(listener);
        }

        /// <summary>
        /// Metode til at kunne logge beskeder ved hjælpe af tracesource
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            _traceSource.TraceInformation(message);
        }
    }
}
