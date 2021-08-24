using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class StereoRadioOnCommand : ICommand
    {
        private Stereo stereo;

        public StereoRadioOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setRadio();
            stereo.setVolume();
        }
        public void undo()
        {
            stereo.off();
        }
    }
}
