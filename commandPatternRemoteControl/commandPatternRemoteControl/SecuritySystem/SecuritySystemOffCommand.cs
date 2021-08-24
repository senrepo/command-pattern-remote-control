using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class SecuritySystemOffCommand : ICommand
    {
        private SecuritySystem securitySystem;

        public SecuritySystemOffCommand(SecuritySystem securitySystem)
        {
            this.securitySystem = securitySystem;
        }

        public void execute()
        {
            securitySystem.disArm();
        }

        public void undo()
        {
            securitySystem.arm();
        }
    }
}
