using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class GameEventListener : MonoBehaviour
{
    public UsedEvents toggleEventVisibility; 

    public GameEvent Event;
    [HideInInspector]
    public UnityEvent Response;
    [HideInInspector]
    public MyIntEvent Response2Int;
    [HideInInspector]
    public MyBoolEvent Response2Bool;
    [HideInInspector]
    public MyFloatEvent Response2Float;

    [HideInInspector]
    public MyVector2Event Response2Vector2;
    [HideInInspector]
    public MyVector3Event Response2Vector3;
    [HideInInspector]
    public MyVector2IntEvent Response2Vector2Int;
    [HideInInspector]
    public MyVector3IntEvent Response2Vector3Int;


    [HideInInspector]
    public MyStringEvent Respose2String;


    private void OnEnable() { 
        Event.RegisterListener(this); 
    }

    private void OnDisable() { 
        Event.UnregisterListener(this);
    }

    public void OnEventRaised() { 
        Response.Invoke();
    }

    public void OnEventRaised(int fish) { 
        Response2Int.Invoke(fish);
    }

    public void OnEventRaised(bool fish) { 
        Response2Bool.Invoke(fish);
    }

    public void OnEventRaised(float fish) { 
        Response2Float.Invoke(fish);
    }

    public void OnEventRaised(Vector2 fish) { 
        Response2Vector2.Invoke(fish);
    }

    public void OnEventRaised(Vector3 fish) { 
        Response2Vector3.Invoke(fish);
    }

    public void OnEventRaised(Vector2Int fish) { 
        Response2Vector2Int.Invoke(fish);
    }

    public void OnEventRaised(Vector3Int fish) { 
        Response2Vector3Int.Invoke(fish);
    }

    public void OnEventRaised(string fish) { 
        Respose2String.Invoke(fish);
    }

}

[System.Flags] 
public enum UsedEvents {
    None      = 0,
    Empty      = 1,
    Int        = 2,
    Bool       = 4,
    Float      = 8, 
    String     = 16,
    Vector2    = 32,   
    Vector3    = 64,  
    Vector2Int = 128,
    Vector3Int = 256
}

#if UNITY_EDITOR
[CustomEditor(typeof(GameEventListener))]
public class GameEventListenerEditor : Editor 
{
    SerializedProperty normaltest;

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        this.serializedObject.Update();
        var myScript = target as GameEventListener;

        // myScript.toggleEventVisibility = GUILayout.Toggle(myScript.toggleEventVisibility, "Flag");
        // myScript.test = GUILayout.Toggle(myScript.test, "Some Bool");
        if((myScript.toggleEventVisibility & UsedEvents.Empty)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Int)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Int"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Bool)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Bool"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.String)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Respose2String"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Float)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Float"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Vector2)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Vector2"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Vector3)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Vector3"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Vector2Int)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Vector2Int"), true);
        }
        if((myScript.toggleEventVisibility & UsedEvents.Vector3Int)!= 0){
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response2Vector3Int"), true);
        }
        this.serializedObject.ApplyModifiedProperties();
    }
}

#endif