using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.ProgramLogger;

namespace DoorModelEventAggregatorPattern
{
    public class SimpleDoor : IDoor
    {
        public Constants.DoorStates Status { get; private set; }
        public SimpleDoor()
        {
            Status = Constants.DoorStates.CLOSED;
        }
        public virtual bool Open()
        {
            if(Status == Constants.DoorStates.CLOSED)
            {
                Status = Constants.DoorStates.OPEN;
                return true;
            }
            return false;
        }
        public virtual bool Close()
        {
            if(Status == Constants.DoorStates.OPEN)
            {
                Status = Constants.DoorStates.CLOSED;
                return true;
            }
            return false;
        }
    }
}
