# customUnityEvents
Unity event using the unity scriptable objects system

## Installation
Just clone this repo and put it in your project's assets folder.

## Usage

### Game Events
Create a new **Game Event** in the Create right click context menu in the project's assets folder.  

Game Events are generic and can be used to transfer stuff like floats, ints, Vector3s, etc. 

### Raising Events
In your code, have a public GameEvent variable declared.  
To raise an event, just raise it as seen in the list in the Game Event Listener component.  
Example:  
```
  public GameEvent myevent;
  void Update() {
    myevent.Raise2String("Any event listeners will receive this string");
    myevent.Raise2Int(24); // and this number
  }
```
### Listening for Events
On the game object, add a **customUnityEvents -> Game Event Listener** component.  
That will list all the posible Game Event types that it can listen too.  
Make sure the Event field is filled.   
Select the correct Game Event type (such as Int) and add a listener.  
Connect that to your script which has a public method that has a parameter that matches the listener. 

