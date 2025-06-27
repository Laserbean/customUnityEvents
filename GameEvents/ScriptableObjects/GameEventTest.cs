

using UnityEngine;
using Laserbean.CustomUnityEvents;
using EasyButtons;

public class GameEventTest : MonoBehaviour
{
    public GameEvent gameEvent;


    [EasyButtons.Button]
    private void RaiseDefaultGameEvent()
    {
        Debug.Log("Raising default value for GameEvent: " + gameEvent.name);
        // gameEvent.Raise();
        // Debug.Log("gameEvent type: " + gameEvent.GetType());
        if (gameEvent is FloatGameEvent floatGameEvent)
        {
            floatGameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is IntGameEvent intGameEvent)
        {
            intGameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is BoolGameEvent boolGameEvent)
        {
            boolGameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is StringGameEvent stringGameEvent)
        {
            stringGameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is Vector2GameEvent vector2GameEvent)
        {
            vector2GameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is Vector3GameEvent vector3GameEvent)
        {
            vector3GameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is Vector2IntGameEvent vector2IntGameEvent)
        {
            vector2IntGameEvent.RaiseDefaultValue();
        }
        else if (gameEvent is Vector3IntGameEvent vector3IntGameEvent)
        {
            vector3IntGameEvent.RaiseDefaultValue();
        }

    }

}
