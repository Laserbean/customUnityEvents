using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Laserbean.EventManager
{
    // This namespace contains the EventManager class and related event classes.
    // The EventManager class provides a centralized event system for the game.
    public static class EventManager
    {
        // A dictionary that maps event types to a list of event listeners.
        private static Dictionary<Type, List<Action<object>>> eventListeners = new Dictionary<Type, List<Action<object>>>();

        // Registers a listener for the specified event type.
        public static void AddListener<T>(Action<T> listener) where T : IEvent
        {
            // Get the type of the event being listened for.
            Type eventType = typeof(T);
            // If the event type isn't already in the dictionary, create a new list for it.
            if (!eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] = new List<Action<object>>();
            }
            // Add the listener to the list of event listeners for this event type.
            eventListeners[eventType].Add((o) => listener((T)o));
        }

        // Removes a listener for the specified event type.
        public static void RemoveListener<T>(Action<T> listener) where T : IEvent
        {
            // Get the type of the event being listened for.
            Type eventType = typeof(T);
            // If the event type is in the dictionary, remove the listener from its list of event listeners.
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType].Remove((o) => listener((T)o));
            }
        }

        // Dispatches an event to all listeners of the specified event type.
        public static void TriggerEvent<T>(T e) where T : IEvent
        {
            // Get the type of the event being triggered.
            Type eventType = typeof(T);
            // If the event type is in the dictionary, call all of its event listeners with the event object.
            if (eventListeners.ContainsKey(eventType))
            {
                foreach (var listener in eventListeners[eventType])
                {
                    listener(e);
                }
            }
        }

        public static void Reset()
        {
            eventListeners.Clear();
        }
    }

}
