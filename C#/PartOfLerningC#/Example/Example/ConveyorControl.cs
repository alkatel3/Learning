using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    
    class ConveyorControl
    {
        public enum Action 
        { 
            Start,
            Stop,
            Forward,
            Reverse
        };
        public void Conveyor(Action com)
        {
            switch (com)
            {
                case Action.Start:
                    Console.WriteLine("Start");
                    break;
                case Action.Stop:
                    Console.WriteLine("Stop");
                    break;
                case Action.Forward:
                    Console.WriteLine("Forward");
                    break;
                case Action.Reverse:
                    Console.WriteLine("Reverse");
                    break;
            }
        }
    }
}
