using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
    [CreateAssetMenu(fileName = "Vector2GameEvent", menuName = GameEventGlobal.SOMenuPath + "/Vector2GameEvent", order = 5)]
    public class Vector2GameEvent : GenericGameEvent<Vector2>
    {
        [Header("Vector2 Game Event"), SerializeField]
#if UNITY_EDITOR
        [ShowOnlyAttribute]
#endif
        string description = "This is a Vector2 Game Event. It can be used to send Vector2 values to listeners.";

    }
}
