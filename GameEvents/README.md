# GameEvents
Unity event using the unity scriptable objects system.

## Installation
Just clone this repo and put it in your project's assets folder.

## Usage

### Game Events
Create a new **Game Event** in the "Scriptable Objects/Laserbean Game Events"

Use the required type that you want to be broadcasted by the event. 

### Raising Events
In your code, have a public GameEvent variable declared.  
To raise an event, just raise it as seen in the list in the Game Event Listener component.  
Example:  
```
  [SerializeField] GameEvent myEvent;
  [SerializeField] IntGameEvent myIntEvent;
  void ExampleFunction() {
    myEvent.Raise();
    myIntEvent.Raise(77);
    myIntEvent.RaiseDefaultValue();
  }
```
### Listening for Events
Use the **Game Event Listener** script. 
It will automatically show the correct UnityEvent type for the attached GameEvent scriptable object. 
All you need to do is to select the appropriate function.  

