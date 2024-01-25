using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    public class SmartDoor : SimpleDoor
    {
        private Timer timerObj;
        private Action<DoorStateChangeEvent> HandleDoorStateChangeEvent;
        public List<ISmartDoorTimerDepAddon> TimerDepAddons;
        public SmartDoor(int t = 10)
        {
            timerObj = new Timer(t);
            TimerDepAddons = new List<ISmartDoorTimerDepAddon>();
            HandleDoorStateChangeEvent = (e) =>
            {
                Close();
            };
            DoorEventAggregator.Instance.Subscribe(HandleDoorStateChangeEvent);
        }
        public override bool Open()
        {
            if (base.Open())
            {
                DoorEventAggregator.Instance.Publish(new DoorStateChangeEvent(Constants.DoorStates.OPEN));
                return true;
            }
            return false;
        }
        public override bool Close()
        {
            if (base.Close())
            {
                DoorEventAggregator.Instance.Publish(new DoorStateChangeEvent(Constants.DoorStates.CLOSED));
                return true;
            }
            return false;
        }
    }
}
