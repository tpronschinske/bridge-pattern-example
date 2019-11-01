using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Models
{
    public abstract class Electronics
    {
        public IState State { get; set; }
        abstract public void MoveToCurrentState();

    }
}
