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
            return new CommandService().GetAll().ToList();
        }

        public void CreateDatabase(string fileName)
        {
            new CommandService().CreateDatabase(fileName);
        }

        public void CreateTable()
        {
            var query = @"CREATE TABLE IF NOT EXISTS `commands` (
	            `id`	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	            `name`	TEXT,
	            `message`	TEXT,
	            `interval`	INTEGER DEFAULT 0,
	            `random_skip`	INTEGER DEFAULT 0,
	            `random_double`	INTEGER DEFAULT 0,
	            `threshold`	INTEGER DEFAULT 0,
	            `break_minutes`	INTEGER DEFAULT 0
            );";
            new CommandService().CreateTable(query);
        }
    }
}
