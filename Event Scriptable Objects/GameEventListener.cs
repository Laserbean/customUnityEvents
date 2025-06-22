using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

namespace Laserbean.CustomUnityEvents
{
    [AddComponentMenu("customUnityEvents/Game Event Listener")]
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Create a GameEvent in the Assets folder. (Create > GameEvent).")]
        public GameEvent Event;
        [Tooltip("Toggles the visibility of event types in the inspector")]
        // public UsedEvents toggleEventVisibility;

        [HideInInspector]
        public UnityEvent Response;
        [HideInInspector]
        public UnityEvent<int> IntResponse;
        [HideInInspector]
        public UnityEvent<bool> BoolResponse;
        [HideInInspector]
        public UnityEvent<float> FloatResponse;

        [HideInInspector]
        public UnityEvent<Vector2> Vector2Response;
        [HideInInspector]
        public UnityEvent<Vector3> Vector3Response;
        [HideInInspector]
        public UnityEvent<Vector2Int> Vector2IntResponse;
        [HideInInspector]
        public UnityEvent<Vector3Int> Vector3IntResponse;


        [HideInInspector]
        public UnityEvent<string> StringResponse;


        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Debug.Log("Event raised without value.");
            Response.Invoke();
        }

        public void OnEventRaised<T>(T arg)
        {
            Debug.Log("Event raised with value: " + arg);
            if (arg.GetType() == typeof(int))
                IntResponse.Invoke((int)(object)arg);
            else if (arg.GetType() == typeof(bool))
                BoolResponse.Invoke((bool)(object)arg);
            else if (arg.GetType() == typeof(float))
                FloatResponse.Invoke((float)(object)arg);
            else if (arg.GetType() == typeof(Vector2))
                Vector2Response.Invoke((Vector2)(object)arg);
            else if (arg.GetType() == typeof(Vector3))
                Vector3Response.Invoke((Vector3)(object)arg);
            else if (arg.GetType() == typeof(Vector2Int))
                Vector2IntResponse.Invoke((Vector2Int)(object)arg);
            else if (arg.GetType() == typeof(Vector3Int))
                Vector3IntResponse.Invoke((Vector3Int)(object)arg);
            else if (arg.GetType() == typeof(string))
                StringResponse.Invoke((string)(object)arg);
        }

    }

    // [System.Flags]
    // public enum UsedEvents
    // {
    //     None = 0,
    //     Empty = 1,
    //     Int = 2,
    //     Bool = 4,
    //     Float = 8,
    //     String = 16,
    //     Vector2 = 32,
    //     Vector3 = 64,
    //     Vector2Int = 128,
    //     Vector3Int = 256
    // }

#if UNITY_EDITOR
    [CustomEditor(typeof(GameEventListener))]
    public class GameEventListenerEditor : Editor
    {
        private SerializedProperty game_event_field;
        GUIStyle SectionNameStyle;
        string SectionName;
        bool showInfo;

        private void OnEnable()
        {
            game_event_field = serializedObject.FindProperty("Event");

            SectionNameStyle = new GUIStyle();

            SectionNameStyle.fontSize = 15;
            showInfo = false;
        }


        SerializedProperty normaltest;
        private static readonly string[] _dontIncludeMe = new string[] { "m_Script" };

        public override void OnInspectorGUI()
        {
            this.serializedObject.Update();

            // Draw the script field like Unity's default inspector
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_Script"));
            EditorGUI.EndDisabledGroup();


            var myScript = target as GameEventListener;

            string eventname = "<Insert Game Event>";
            string eventtype = "";
            if (game_event_field.objectReferenceValue)
            {
                var eventObj = game_event_field.objectReferenceValue;
                var eventType = eventObj.GetType();

                var path = AssetDatabase.GetAssetPath(eventObj).Split('/');
                eventname = (path[path.Length - 1]).Split('.')[0];

                // Optionally, display the type
                eventtype = $" ({eventType.Name})";
            }

            // showInfo = EditorGUILayout.BeginFoldoutHeaderGroup(showInfo, eventname + eventtype);

            // if (showInfo)
            // {
            DrawPropertiesExcluding(serializedObject, _dontIncludeMe);

            if (game_event_field.objectReferenceValue)
            {
                var eventObj = game_event_field.objectReferenceValue;
                var eventType = eventObj.GetType();

                // Show the UnityEvent field based on the GameEvent type
                if (eventType.Name == "IntGameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("IntResponse"), true);
                else if (eventType.Name == "BoolGameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("BoolResponse"), true);
                else if (eventType.Name == "FloatGameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("FloatResponse"), true);
                else if (eventType.Name == "StringGameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("StringResponse"), true);
                else if (eventType.Name == "Vector2GameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector2Response"), true);
                else if (eventType.Name == "Vector3GameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector3Response"), true);
                else if (eventType.Name == "Vector2IntGameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector2IntResponse"), true);
                else if (eventType.Name == "Vector3IntGameEvent")
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector3IntResponse"), true);
                else // fallback for base GameEvent or unknown types
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response"), true);
            }
            // }

            EditorGUILayout.EndFoldoutHeaderGroup();
            this.serializedObject.ApplyModifiedProperties();
        }
    }

#endif
}