using System;
using System.Collections.Generic;
using System.Text;

namespace commandPatternRemoteControl
{
    public interface ICommand
    {
        void execute();
        void undo();
    }
}
