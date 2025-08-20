using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
  [CreateAssetMenu(fileName = "Vector3GameEvent", menuName = GameEventGlobal.SOMenuPath + "/Vector3GameEvent", order = 7)]
  public class Vector3GameEvent : GenericGameEvent<Vector3>
  {
    [Header("Vector3 Game Event"), SerializeField]
#if UNITY_EDITOR
        [ShowOnlyAttribute]
#endif
    string description = "This is a Vector3 Game Event. It can be used to send Vector3 values to listeners.";

  }
}
