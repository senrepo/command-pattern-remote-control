using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class SecuritySystemOnCommand : ICommand
    {
        private SecuritySystem securitySystem;

        public SecuritySystemOnCommand(SecuritySystem securitySystem)
        {
            this.securitySystem = securitySystem;
        }

        public void execute()
        {
            securitySystem.arm();
        }

        public void undo()
        {
            securitySystem.disArm();
        }
    }
}
