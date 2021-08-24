using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class GarageOpenCommand : ICommand
    {
        private Garage garage;

        public GarageOpenCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void execute()
        {
            garage.open();
            garage.lightOn();
        }

        public void undo()
        {
            garage.close();
            garage.lightOff();
        }
    }
}
