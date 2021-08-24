using System;
using System.Collections.Generic;
using System.Text;

namespace commandPatternRemoteControl
{
    public class HomeArrivalCommand : ICommand
    {
        private List<ICommand> commands;

        public HomeArrivalCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            foreach (var command in commands)
            {
                command.execute();
            }
        }

        public void undo()
        {
            foreach (var command in commands)
            {
                command.undo();
            }
        }
    }
}
