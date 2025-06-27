
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

        protected List<IGameEventListener> listeners = new List<IGameEventListener>();

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(IGameEventListener listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
            }
        }

        public void UnregisterListener(IGameEventListener listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }
        
    }
}
