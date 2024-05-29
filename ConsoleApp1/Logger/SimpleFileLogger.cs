using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Logger
{
    internal class SimpleFileLogger : ISimpleLogger
    {
        private string _file;
        public SimpleFileLogger(string file) 
        {
            _file = file;
        }
        public void Log(string message)
        {
            var line = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {message}";

            File.AppendAllText(_file, Environment.NewLine + line);
        }

        public void Log(Exception exception)
        {
            var line = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {exception.Message}";

            File.AppendAllText(_file, Environment.NewLine + line);
        }
    }
}
