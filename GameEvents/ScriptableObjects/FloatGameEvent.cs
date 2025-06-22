using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
    [CreateAssetMenu(fileName = "FloatGameEvent", menuName = "Scriptable Objects/Laserbean Game Events/FloatGameEvent")]
    public class FloatGameEvent : GenericGameEvent<float>
    {
        [Header("Float Game Event"), SerializeField]
        [ShowOnlyAttribute] string description = "This is a Float Game Event. It can be used to send float values to listeners.";
    }
}
