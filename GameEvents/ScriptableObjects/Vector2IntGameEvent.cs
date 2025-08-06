using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
    [CreateAssetMenu(fileName = "Vector2IntGameEvent", menuName = GameEventGlobal.SOMenuPath + "/Vector2IntGameEvent", order = 6)]
    public class Vector2IntGameEvent : GenericGameEvent<Vector2Int>
    {
        [Header("Vector2Int Game Event"), SerializeField]
#if UNITY_EDITOR
        [ShowOnlyAttribute]
#endif
        string description = "This is a Vector2Int Game Event. It can be used to send Vector2Int values to listeners.";
    }
}
