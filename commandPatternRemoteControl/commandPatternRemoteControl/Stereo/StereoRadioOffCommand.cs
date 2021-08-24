using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class StereoRadioOffCommand : ICommand
    {
        private Stereo stereo;

        public StereoRadioOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }
        public void undo()
        {
            stereo.on();
            stereo.setRadio();
            stereo.setVolume();
        }
    }
}
