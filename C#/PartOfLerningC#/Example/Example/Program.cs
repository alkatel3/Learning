using System;

namespace Example
{
    class Program
    {
       

        static void Main(string[] args)
        {
            var conveyor = new ConveyorControl();

            conveyor.Conveyor(ConveyorControl.Action.Start);
            conveyor.Conveyor(ConveyorControl.Action.Stop);
            conveyor.Conveyor(ConveyorControl.Action.Reverse);
            conveyor.Conveyor(ConveyorControl.Action.Forward);
        }
    }
}
