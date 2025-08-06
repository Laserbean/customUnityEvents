using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
    [CreateAssetMenu(fileName = "BoolGameEvent", menuName = GameEventGlobal.SOMenuPath + "/BoolGameEvent", order = 4)]
    public class BoolGameEvent : GenericGameEvent<bool>
    {
        [Header("Bool Game Event"), SerializeField]

#if UNITY_EDITOR
        [ShowOnlyAttribute]
#endif


        string description = "This is a Bool Game Event. It can be used to send bool values to listeners.";

    }
}
