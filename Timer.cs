using System;
using Zeiss.Timers;

namespace DoorModelEventAggregatorPattern
{
    public class Timer
    {
        public int timeDelayInSec { get; private set; }
        public event Action<DoorStateChangeEvent> HandleDoorStateChangeEvent;
        // event keyword to make it accessible only for add/remove not to invoke it
        public Timer(int t)
        {
            timeDelayInSec = t;
            HandleDoorStateChangeEvent = (e) =>
            {
                if (e.State == Constants.DoorStates.OPEN)
                {
                    Timers.StartTimer(timeDelayInSec, timerCallback, null);
                }
                else
                {
                    Timers.StopTimer();
                }
            };
            DoorEventAggregator.Instance.Subscribe(HandleDoorStateChangeEvent);
        }
        private void timerCallback(object obj)
        {
            DoorEventAggregator.Instance.Publish(new TimerElapsedEvent());
        }
       
    }
}