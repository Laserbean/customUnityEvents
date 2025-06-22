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
        public UsedEvents toggleEventVisibility;

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

    [System.Flags]
    public enum UsedEvents
    {
        None = 0,
        Empty = 1,
        Int = 2,
        Bool = 4,
        Float = 8,
        String = 16,
        Vector2 = 32,
        Vector3 = 64,
        Vector2Int = 128,
        Vector3Int = 256
    }

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
            // base.OnInspectorGUI();

            this.serializedObject.Update();

            // serializedObject.ApplyModifiedProperties();

            var myScript = target as GameEventListener;

            string eventname = "<Insert Game Event>";
            string eventtype = "";
            if (game_event_field.objectReferenceValue)
            {
                var path = AssetDatabase.GetAssetPath(game_event_field.objectReferenceValue).Split('/');
                eventname = (path[path.Length - 1]).Split('.')[0];

                if ((myScript.toggleEventVisibility & UsedEvents.Empty) != 0)
                {
                    eventtype += " (void)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Int) != 0)
                {
                    eventtype += " (int)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Bool) != 0)
                {
                    eventtype += " (bool)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.String) != 0)
                {
                    eventtype += " (string)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Float) != 0)
                {
                    eventtype += " (float)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector2) != 0)
                {
                    eventtype += " (Vector2)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector3) != 0)
                {
                    eventtype += " (Vector3)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector2Int) != 0)
                {
                    eventtype += " (Vector2Int)";
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector3Int) != 0)
                {
                    eventtype += " (Vector3Int)";
                }
                // EditorGUILayout.BeginHorizontal();
                // try {
                // EditorGUILayout.LabelField(eventname, SectionNameStyle);
                // } finally {
                // EditorGUILayout.EndHorizontal();
                // }
            }

            showInfo = EditorGUILayout.BeginFoldoutHeaderGroup(showInfo, eventname + eventtype);

            if (showInfo)
            {
                DrawPropertiesExcluding(serializedObject, _dontIncludeMe);

                // myScript.toggleEventVisibility = GUILayout.Toggle(myScript.toggleEventVisibility, "Flag");
                // myScript.test = GUILayout.Toggle(myScript.test, "Some Bool");
                if ((myScript.toggleEventVisibility & UsedEvents.Empty) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Response"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Int) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("IntResponse"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Bool) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("BoolResponse"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.String) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("StringResponse"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Float) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("FloatResponse"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector2) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector2Response"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector3) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector3Response"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector2Int) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector2IntResponse"), true);
                }
                if ((myScript.toggleEventVisibility & UsedEvents.Vector3Int) != 0)
                {
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty("Vector3IntResponse"), true);
                }

            }

            EditorGUILayout.EndFoldoutHeaderGroup();
            this.serializedObject.ApplyModifiedProperties();
        }
    }

#endif
}