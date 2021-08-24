using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class StereoCdOffCommand : ICommand
    {
        private Stereo stereo;

        public StereoCdOffCommand(Stereo stereo)
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
            stereo.setCd();
            stereo.setVolume();
        }
    }
}
