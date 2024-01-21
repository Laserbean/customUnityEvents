using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using Laserbean.CustomUnityEvents;

public class buttonToGameEvent : MonoBehaviour
{

    [SerializeField] GameEvent buttonEvent;

    public void OnButtonPressed()
    {
        buttonEvent.Raise();
    }
}
