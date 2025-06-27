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

        public void Raise(T arg)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(arg);
        }

        [SerializeField]
        private T defaultValue;

        public void RaiseDefaultValue()
        {
            Raise(defaultValue);
        }
    }
}
