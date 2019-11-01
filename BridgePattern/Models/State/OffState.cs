using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Models.State
{
    class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Off State");
        }
    }
}
