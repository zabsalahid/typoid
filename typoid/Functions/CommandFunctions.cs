using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using typoid.Models;
using typoid.Services;

namespace typoid.Functions
{
    public class CommandFunctions
    {
        public long InsertCommand(Command newCommand)
        {
            return new CommandService().Add(newCommand);
        }

        public void UpdateCommand(Command existingCommand)
        {
            new CommandService().Update(existingCommand);
        }

        public void DeleteCommand(Command existongCommand)
        {
            new CommandService().DeleteById(existongCommand.id);
        }

        public Command GetCommand(long id)
        {
            return new CommandService().GetById(id);
        }

        public List<Command> GetCommands()
        {
            CommandService svc = new CommandService();
            return svc.GetAll().ToList();
        }
    }
}
