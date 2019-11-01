using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Models
{
    class VCD : Electronics
    {
        public override void MoveToCurrentState()
        {
            State.MoveState();
        }
    }
}
