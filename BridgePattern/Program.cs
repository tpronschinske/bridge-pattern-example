using BridgePattern.Interfaces;
using BridgePattern.Models;
using BridgePattern.Models.State;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern");

            Electronics item = new Television();
            IState presentState = new OnState();

            item.State = presentState;
            presentState = new OffState();
            item.State = presentState;
            item.MoveToCurrentState();

            presentState = new OnState();
            item.State = presentState;
            item.MoveToCurrentState();
        }
    }
}
