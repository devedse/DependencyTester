using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DependencyTester
{
    public class Writer : IWriter
    {
        public Writer()
        {

        }

        public void WriteLine(string data)
        {
            File.AppendAllText("output.txt", data);
        }
    }
}
