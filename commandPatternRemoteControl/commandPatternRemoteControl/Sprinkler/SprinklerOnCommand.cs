using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class SprinklerOnCommand : ICommand
    {
        private Sprinkler sprinkler;

        public SprinklerOnCommand(Sprinkler sprinkler)
        {
            this.sprinkler = sprinkler;
        }

        public void execute()
        {
            sprinkler.waterOn();
        }

        public void undo()
        {
            sprinkler.waterOff();
        }
    }
}
