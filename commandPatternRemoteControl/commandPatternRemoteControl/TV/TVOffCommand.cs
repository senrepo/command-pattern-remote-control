using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class TVOffCommand : ICommand
    {
        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
        }
    }
}
