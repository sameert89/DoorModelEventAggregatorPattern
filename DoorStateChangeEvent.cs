using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    public class DoorStateChangeEvent
    {
        public Constants.DoorStates State { get; private set; }
        public DoorStateChangeEvent(Constants.DoorStates newState)
        {
            State = newState;
        }
    }
}
