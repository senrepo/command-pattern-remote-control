using System;
using System.Collections.Generic;
using System.Text;
using Vendor;

namespace commandPatternRemoteControl
{
    public class StereoCdOnCommand : ICommand
    {
        private Stereo stereo;

        public StereoCdOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume();
        }

        public void undo()
        {
            stereo.off();
        }
    }
}
