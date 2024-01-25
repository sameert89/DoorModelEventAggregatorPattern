using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorModelEventAggregatorPattern
{
    public sealed class DoorEventAggregator : IEventHandler
    {
        private static readonly DoorEventAggregator instance = new DoorEventAggregator();
        private readonly Dictionary<Type, List<Action<object>>> subscribers =
            new Dictionary<Type, List<Action<object>>>();

        // Singleton (Expression Bodied Syntax)
        public static DoorEventAggregator Instance => instance;

        public void Subscribe<TEvent>(Action<TEvent> action)
        {
            var eventType = typeof(TEvent);
            if (!subscribers.ContainsKey(eventType))
            {
                subscribers[eventType] = new List<Action<object>>();
            }

            subscribers[eventType].Add(obj => action((TEvent)obj));
        }

        public void Publish<TEvent>(TEvent @event)
        {
            var eventType = typeof(TEvent);
            if (subscribers.ContainsKey(eventType))
            {
                foreach (var subscriber in subscribers[eventType])
                {
                    subscriber(@event);
                }
            }
        }
    }
}
