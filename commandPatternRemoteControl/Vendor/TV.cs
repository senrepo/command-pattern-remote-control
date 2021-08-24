using System;

namespace Vendor
{
    public class TV
    {
        public void on()
        {
            Console.WriteLine("Tv is on");
        }
        public void off()
        {
            Console.WriteLine("Tv is off");
        }
        public void Mute ()
        {
            Console.WriteLine("Tv volume muted");
        }
        public void unMute()
        {
            Console.WriteLine("Tv volume unMuted");
        }
    }
}
