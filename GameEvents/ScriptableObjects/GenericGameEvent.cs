using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEditor;
using System;

// This code is part of the Laserbean Custom Unity Events package.
namespace Laserbean.CustomUnityEvents
{

    // [CreateAssetMenu(fileName = "GenericGameEvent", menuName = "Scriptable Objects/GenericGameEvent")]
    public abstract class GenericGameEvent<T> : GameEvent
    {

        protected new event System.Action<T> OnEventRaised;

        public void Raise(T arg)
        {
            OnEventRaised?.Invoke(arg);
        }

        [SerializeField]
        private T defaultValue;

        public void RaiseDefaultValue()
        {
            Raise(defaultValue);
        }

        public override void RegisterListener(IGameEventListener listener)
        {
            OnEventRaised += listener.OnEventRaised;
        }

        public override void UnregisterListener(IGameEventListener listener)
        {
            OnEventRaised -= listener.OnEventRaised;
        }
    }
}
