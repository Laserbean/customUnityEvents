using System.ComponentModel;
using UnityEngine;

namespace Laserbean.CustomUnityEvents

{
   [CreateAssetMenu(fileName = "TransformGameEvent", menuName = "Scriptable Objects/Laserbean Game Events/TransformGameEvent", order = 9)]
   public class TransformGameEvent : GenericGameEvent<Transform>
   {
       [Header("Transform Game Event"), SerializeField]
       [ShowOnlyAttribute] string description = "This is a Transform Game Event. It can be used to send Transform values to listeners.";
   }
}
