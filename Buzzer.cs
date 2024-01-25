using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.ProgramLogger;

namespace DoorModelEventAggregatorPattern
{
    public class Buzzer : ISmartDoorTimerDepAddon
    {
        public Action<TimerElapsedEvent> HandleTimerElapsedEvent { get; set; }
        public Buzzer()
        {
            HandleTimerElapsedEvent = (e) =>
            {
                Console.Beep();
            };
            DoorEventAggregator.Instance.Subscribe<TimerElapsedEvent>(HandleTimerElapsedEvent);
        }
    }
}
