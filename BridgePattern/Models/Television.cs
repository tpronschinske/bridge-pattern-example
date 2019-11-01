using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Models
{
    class Television : Electronics
    {
        public override void MoveToCurrentState()
        {
            State.MoveState();
        }
    }
}
