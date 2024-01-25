using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    interface IEventHandler
    {
        void Subscribe<TEvent>(Action<TEvent> action);
        void Publish<TEvent>(TEvent @event);
    }
}
