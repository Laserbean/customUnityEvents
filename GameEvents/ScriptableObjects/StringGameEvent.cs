using System.ComponentModel;
using UnityEngine;

// This code is part of the Laserbean Custom Unity Events package.

namespace Laserbean.CustomUnityEvents
{
  [CreateAssetMenu(fileName = "StringGameEvent", menuName = GameEventGlobal.SOMenuPath + "/StringGameEvent", order = 9)]
  public class StringGameEvent : GenericGameEvent<string>
  {
    [Header("String Game Event"), SerializeField]
#if UNITY_EDITOR
        [ShowOnlyAttribute]
#endif
    string description = "This is a String Game Event. It can be used to send string values to listeners.";

  }
}
