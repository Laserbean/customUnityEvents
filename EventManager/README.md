# Event Manager

    void ExampleFunction() {

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
public class SampleEvent : IEvent {
    // Event classes can contain data that is relevant to the event.
    // This example event class doesn't contain any data.
}
