using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
   [CreateAssetMenu(fileName = "Vector3IntGameEvent", menuName = "Scriptable Objects/Laserbean Game Events/Vector3IntGameEvent", order = 8)]
   public class Vector3IntGameEvent : GenericGameEvent<Vector3Int>
   {
       [Header("Vector3Int Game Event"), SerializeField]
       [ShowOnlyAttribute] string description = "This is a Vector3Int Game Event. It can be used to send Vector3Int values to listeners.";
   }
}
