using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyTester
{
    public class Logger : ILogger
    {
        private IWriter _writer;

        public Logger(IWriter writer)
        {
            _writer = writer;
        }

        public void LogString(string str)
        {
            str = $"{DateTime.Now}: {str}";
            _writer.WriteLine(str);
        }

        public void LogStringShitMethode(string str)
        {
            str = $"{DateTime.Now}: {str}";

            var writer = new Writer();
            writer.WriteLine(str);
        }
    }
}
