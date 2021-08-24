using System;
using System.Collections.Generic;
using Vendor;

namespace commandPatternRemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Requirement for Home Automation Remote control.
             * The remote control has seven programmable slots.
             * Each can be assigned to a different household device along with on/off buttons.
             * The remote also has a global undo button.
             * Vendor class to control the home automation device such as light, audio, garage equipments, etc
             * Requirement is to create the programming logic for each slot can be assigned to control a device.
             * Note that its important that we are able to control the current device and also any future device that the vendor may supply.
             * We look forward to seeing your design.
             */
            
            /* slot 0, Lights On, Lights Off
             * slot 1, TV On, TV Off
             * slot 2, Stereo Radio On, Stereo Radio Off
             * slot 3, Garage Open, Garage Close
             * slot 4, Security System On, Security System Off
             * slot 5, Sprinkler On, Sprinkler Off
             * slot 6, Home Away, Home Arrival
             * slot 100, undo
             */

            var remoteControl = new RemoteControl();

            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);
            remoteControl.setCommand(0, lightOnCommand, lightOffCommand);

            var tv = new TV();
            var tvOnCommand = new TVOnCommand(tv);
            var tvOffCommand = new TVOffCommand(tv);
            remoteControl.setCommand(1, tvOnCommand  , tvOffCommand);

            var stereo = new Stereo();
            var stereoRadioOnCommand = new StereoRadioOnCommand(stereo);
            var stereoRadioOffCommand = new StereoRadioOffCommand(stereo);
            remoteControl.setCommand(2, stereoRadioOnCommand, stereoRadioOffCommand);

            var garage = new Garage();
            var garageOpenCommand = new GarageOpenCommand(garage);
            var garageCloseCommand = new GarageCloseCommand(garage);
            remoteControl.setCommand(3, garageOpenCommand, garageCloseCommand);

            var securitySystem = new SecuritySystem();
            var securitySystemOnCommand = new SecuritySystemOnCommand(securitySystem);
            var securitySystemOffCommand = new SecuritySystemOffCommand(securitySystem);
            remoteControl.setCommand(4,  securitySystemOnCommand, securitySystemOffCommand);


            var sprinkler = new Sprinkler();
            var sprinklerOnCommand = new SprinklerOnCommand(sprinkler);
            var sprinklerOffCommand = new SprinklerOffCommand(sprinkler);
            remoteControl.setCommand(5, sprinklerOnCommand, sprinklerOffCommand);

            var homeAwayCommands = new HomeAwayCommand(new List<ICommand>
            {
                 lightOffCommand, tvOffCommand, stereoRadioOffCommand, garageCloseCommand, sprinklerOffCommand, securitySystemOnCommand
            });

            var homeArrivalCommands = new HomeArrivalCommand(new List<ICommand>
            {
                 lightOnCommand, garageOpenCommand, tvOnCommand, securitySystemOnCommand
            });
            remoteControl.setCommand(6, homeAwayCommands, homeArrivalCommands);


            Console.WriteLine("Remote Contorl button Info");
            Console.WriteLine("00 -> Light On, 01 -> Light Off ");
            Console.WriteLine("10 -> TV On, 11 -> TV Off ");
            Console.WriteLine("20 -> Stereo Radio On, 21 -> Stereo Radio Off ");
            Console.WriteLine("30 -> Garage Open, 31 -> Garage Close ");
            Console.WriteLine("40 -> Security System On, 41 -> Security System Off ");
            Console.WriteLine("50 -> Sprinkler On, 51 -> Sprinkler Off ");
            Console.WriteLine("60 -> Home Away, 61 -> Home Arrival");
            Console.WriteLine("100 -> undo");

            string input;
            do
            {
                Console.WriteLine("Please enter a valid input ");
                input = Console.ReadLine();

                if( int.TryParse(input, out int number))
                {
                    if (number == 100)
                    {
                        remoteControl.undoButtonPressed();
                    }
                    else
                    {
                        int slot = number / 10;
                        int mod = number % 10;

                        if (mod == 0)
                        {
                            remoteControl.onButtonPressed(slot);
                        }
                        else
                        {
                            remoteControl.offButtonPressed(slot);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            } while (input.ToUpper() != "EXIT");
        }
    }
}
