using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyTester
{
    public class Calculator : ICalculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger, IWriter writer)
        {
            _logger = logger;
        }

        public void DoeIets()
        {
            Console.WriteLine("5 + 5 = 10");
            _logger.LogString("5 + 5 = 10");
        }
    }
}
