using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class SprinklerOffCommand : ICommand
    {
        private Sprinkler sprinkler;

        public SprinklerOffCommand(Sprinkler sprinkler)
        {
            this.sprinkler = sprinkler;
        }

        public void execute()
        {
            sprinkler.waterOff();
        }

        public void undo()
        {
            sprinkler.waterOn();
        }
    }

}
