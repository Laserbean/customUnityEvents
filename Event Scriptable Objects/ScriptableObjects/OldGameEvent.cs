﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laserbean.CustomUnityEvents
{
    [CreateAssetMenu(fileName = "NewGameEvent", menuName = "Events/Game Event")]
    public class OldGameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new();

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised();
        }

        public void Raise2Int(int num)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(num);
        }

        public void Raise2Float(float num1)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(num1);
        }

        public void Raise2Bool(bool boo)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(boo);
        }

        public void Raise2Vector2(Vector2 vec)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(vec);
        }

        public void Raise2Vector3(Vector3 vec)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(vec);
        }

        public void Raise2Vector2Int(Vector2Int vec)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(vec);
        }

        public void Raise2Vector3Int(Vector3Int vec)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(vec);
        }

        public void Raise2String(string str1)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(str1);
        }



        public void RegisterListener(GameEventListener listener) => listeners.Add(listener);

        public void UnregisterListener(GameEventListener listener) => listeners.Remove(listener);
    }
}