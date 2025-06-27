
using UnityEngine;
using System.Collections.Generic;

namespace Laserbean.CustomUnityEvents
{
    [System.Serializable]

    [CreateAssetMenu(fileName = "GameEvent", menuName = "Scriptable Objects/Laserbean Game Events/GameEvent", order = 1)]
    public class GameEvent : ScriptableObject
    {

        // [Header("Float Game Event"), SerializeField]
        // [ShowOnlyAttribute] string base_description = "This is a normal Game Event. Doesn't send anything but notifies when raised.";

        [TextArea(3, 3), SerializeField]
        protected string Notes;

        protected event System.Action OnEventRaised;

        public void Raise()
        {
            OnEventRaised?.Invoke();
        }


        public virtual void RegisterListener(IGameEventListener listener)
        {
            OnEventRaised += listener.OnEventRaised;
        }

        public virtual void UnregisterListener(IGameEventListener listener)
        {
            OnEventRaised -= listener.OnEventRaised;
        }
        
    }
}
