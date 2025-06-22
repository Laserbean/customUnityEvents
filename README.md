# customUnityEvents

Contains 3 different event systems:
- GameEvents
    - Scriptable object events
    - Read [GameEvents/README.md](GameEvents/README.md)
- EventManager
    - Static Event Manager system. (needs updating)
- EventBus
    - Stolen code. Please refer to [EventBus/README.md](EventBus/README.md) for more info. 

## Event Manager Usage


    void Start() {

        // Register a listener for the event.
        EventManager.AddListener<SampleEvent>(OnSampleEvent);

        // Trigger the event.
        EventManager.TriggerEvent(new SampleEvent());

        // Unregister the listener.
        EventManager.RemoveListener<SampleEvent>(OnSampleEvent);
    }

    void OnSampleEvent(SampleEvent e) {
        Debug.Log("Event has happened!");
    }


// An example event class that can be used with the EventManager.
public class SampleEvent {
    // Event classes can contain data that is relevant to the event.
    // This example event class doesn't contain any data.
}
