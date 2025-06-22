using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
    [CreateAssetMenu(fileName = "BoolGameEvent", menuName = "Scriptable Objects/Laserbean Game Events/BoolGameEvent")]
    public class BoolGameEvent : GenericGameEvent<bool>
    {
        [Header("Bool Game Event"), SerializeField]
        [ShowOnlyAttribute] string description = "This is a Bool Game Event. It can be used to send bool values to listeners.";

    }
}
