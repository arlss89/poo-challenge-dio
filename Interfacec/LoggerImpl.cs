using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pooChallengeDioMain.Interfaces
{
    public class LoggerImpl : ILogger
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public void WriteLine(string className, string message)
        {
            Console.WriteLine(className + message);
        }
    }
}