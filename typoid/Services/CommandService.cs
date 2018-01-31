using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using typoid.Common;
using typoid.Models;
using typoid.Utility;

namespace typoid.Services
{
    public class CommandService : BaseService<Command>
    {
        public CommandService() : base(Storage.ConnectionString)
        {
        }
    }
}
