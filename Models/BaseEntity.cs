using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pooChallengeDioMain.Interfaces;

namespace DesafioPOO.Models
{
    public abstract class BaseEntity
    {
        public readonly ILogger _logger;

        public BaseEntity() {
            _logger = new LoggerImpl();
        }

        public string getClassName()
        {
            return $"{this.GetType().Name} ";
        }
    }
}