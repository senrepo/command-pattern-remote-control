using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class GarageCloseCommand : ICommand
    {
        private Garage garage;

        public GarageCloseCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void execute()
        {
            garage.close();
            garage.lightOff();
        }

        public void undo()
        {
            garage.open();
            garage.lightOn();
        }
    }
}
