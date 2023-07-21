using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System; 


// The EventManager class provides a centralized event system for the game.
public static class EventManager {
    
    // A dictionary that maps event types to a list of event listeners.
    private static Dictionary<Type, List<Action<object>>> eventListeners= new Dictionary<Type, List<Action<object>>>();


    // Registers a listener for the specified event type.
    public static void AddListener<T>(Action<T> listener) {
        // Get the type of the event being listened for.
        Type eventType = typeof(T);
        // If the event type isn't already in the dictionary, create a new list for it.
        if (!eventListeners.ContainsKey(eventType)) {
            eventListeners[eventType] = new List<Action<object>>();
        }
        // Add the listener to the list of event listeners for this event type.
        eventListeners[eventType].Add((o) => listener((T)o));
    }

    // Removes a listener for the specified event type.
    public static void RemoveListener<T>(Action<T> listener) {
        // Get the type of the event being listened for.
        Type eventType = typeof(T);
        // If the event type is in the dictionary, remove the listener from its list of event listeners.
        if (eventListeners.ContainsKey(eventType)) {
            eventListeners[eventType].Remove((o) => listener((T)o));
        }
    }

    // Dispatches an event to all listeners of the specified event type.
    public static void TriggerEvent<T>(T e) {
        // Get the type of the event being triggered.
        Type eventType = typeof(T);
        // If the event type is in the dictionary, call all of its event listeners with the event object.
        if (eventListeners.ContainsKey(eventType)) {
            foreach (var listener in eventListeners[eventType]) {
                listener(e);
            }
        }
    }


    public static void Reset() {
        eventListeners.Clear();
    }
}


// public class EventM<T> {
//     Type<T> value;
//     public EventM(Type<T> thing) {

//     }
// }

public class SingleItemEvent
{
    public object value;

    public SingleItemEvent(object _value)
    {
        this.value = _value;
    }
}


public class DoubleItemEvent
{
    public object value;
    public object value2;

    public DoubleItemEvent(object _value, object _value2)
    {
        this.value = _value;
        this.value2 = _value2;
    }
}



/*
using UnityEngine;

public class Example : MonoBehaviour {
    private EventManager eventManager;

    void Start() {
        // Create a new EventManager instance.
        eventManager = new EventManager();

        // Register a listener for the "PlayerDied" event.
        eventManager.AddListener<PlayerDiedEvent>(OnPlayerDied);

        // Trigger the "PlayerDied" event.
        eventManager.TriggerEvent(new PlayerDiedEvent());

        // Unregister the "OnPlayerDied" method from the "PlayerDied" event.
        eventManager.RemoveListener<PlayerDiedEvent>(OnPlayerDied);
    }

    // This method will be called when the "PlayerDied" event is triggered.
    void OnPlayerDied(PlayerDiedEvent e) {
        Debug.Log("The player has died!");
    }
}

// An example event class that can be used with the EventManager.
public class PlayerDiedEvent {
    // Event classes can contain data that is relevant to the event.
    // This example event class doesn't contain any data.
}



EventManager.Instance.TriggerEvent(new PlayerDiedEvent(player));

*/
