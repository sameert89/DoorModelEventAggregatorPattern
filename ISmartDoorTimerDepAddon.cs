using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    public interface ISmartDoorTimerDepAddon
    {
        Action<TimerElapsedEvent> HandleTimerElapsedEvent { get; set; }
    }
}
