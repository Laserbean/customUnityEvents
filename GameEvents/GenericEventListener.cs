using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;



namespace Laserbean.CustomUnityEvents
{
    [AddComponentMenu("customUnityEvents/Game Event Listener")]
    public abstract class GenericEventListener<T> : MonoBehaviour, IGameEventListener
    {
        [Tooltip("Create a GameEvent in the Assets folder. (Create > GameEvent).")]
        public GameEvent Event;

        public UnityEvent Response;
        public UnityEvent<T> TResponse;


        private void OnEnable()
        {
            if (Event == null)
            {
                Debug.LogWarning("GameEventListener: No GameEvent assigned. Please assign a GameEvent in the inspector.");
                return;
            }
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (Event == null)
            {
                return;
            }
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Debug.Log("Event raised without value.");
            Response.Invoke();
        }

        public void OnEventRaised<T2>(T2 arg)
        {
            Debug.Log("Event raised with value: " + arg);
            if (arg.GetType() == typeof(T))
                TResponse.Invoke((T)(object)arg);
        }
    }
}

