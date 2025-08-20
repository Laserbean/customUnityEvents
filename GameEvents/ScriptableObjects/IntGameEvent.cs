using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
  [CreateAssetMenu(fileName = "IntGameEvent", menuName = GameEventGlobal.SOMenuPath + "/IntGameEvent", order = 2)]
  public class IntGameEvent : GenericGameEvent<int>
  {
    [Header("Int Game Event"), SerializeField]
#if UNITY_EDITOR
        [ShowOnlyAttribute]
#endif
    string description = "This is an Int Game Event. It can be used to send int values to listeners.";
  }
}
