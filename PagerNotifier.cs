using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.ProgramLogger;

namespace DoorModelEventAggregatorPattern
{
    public class PagerNotifier : ISmartDoorTimerDepAddon
    {
        public Action<TimerElapsedEvent> HandleTimerElapsedEvent { get; set; }
        public PagerNotifier()
        {
            HandleTimerElapsedEvent = (e) =>
            {
                // Pager Logic
            };
            DoorEventAggregator.Instance.Subscribe<TimerElapsedEvent>(HandleTimerElapsedEvent);
        }
    }
}
