# UnityEvents
Unity event using the unity scriptable objects system

## Installation
Just clone this repo and put it in your project's assets folder.

## Usage

### Game Events
Create a new **Game Event** in the Create right click menu in the projects 

Game Events are generic and can be used to transfer stuff like floats, ints, Vector3s, etc. 

### Listening for Events
On the game object, add a **Game Event Listener** component. That will list all the posible Game Event types that it can listen too.  
Make sure the Event (created in the previous step) is filled.   
Select the correct Game Event type (such as Int) and add a listener. Connect that to your script which has a public function that has a parameter that matches the listener. 

### Raising Events
In your code, have a public GameEvent variable declared.  
To raise an event, just raise it as seen in the list in the Game Event Listener component.  
Example:  
  public GameEvent myevent;
  void Update() {
    myevent.Raise2String("Any event listeners will receive this string");
    myevent.Raise2Int(24); // and this number
  }
