using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class HomeAwayCommand : ICommand
    {
        private List<ICommand> commands;

        public HomeAwayCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            foreach(var command in commands)
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
