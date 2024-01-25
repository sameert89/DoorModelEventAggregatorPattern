using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buying Door
            SmartDoor myDoor = new SmartDoor();
            // Subscribing Addons
            myDoor.TimerDepAddons.Add(new Buzzer());
            myDoor.TimerDepAddons.Add(new PagerNotifier());
            myDoor.TimerDepAddons.Add(new AutoClose());
            // Testing
            myDoor.Open();
        }
    }
}
