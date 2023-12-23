using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pooChallengeDioMain.Interfaces

{
    public interface ILogger
    {
        void WriteLine(string message);
        void WriteLine(string className, string message);
    }
}