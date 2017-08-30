//using System.Collections;
//using System.Collections.Generic;

//using UnityEditor;
//using VapeEvents;

//public class EventListInspector : Editor
//{
//    [CustomEditor(typeof(EventManager))]
//    public override void OnInspectorGUI()
//    {
//        serializedObject.Update();
//        EventListInspector.Show(serializedObject.FindProperty("Events"));
//        serializedObject.ApplyModifiedProperties();
//    }

//    public static void Show(SerializedProperty list)
//    {
//        EditorGUILayout.PropertyField(list);
//        EditorGUI.indentLevel += 1;
//        if(list.isExpanded)
//        {
//            EditorGUILayout.PropertyField(list.FindPropertyRelative("Array.size"));
//            for (int i = 0; i < list.arraySize; i++)
//            {
//                EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
//            }
//        }

//        EditorGUI.indentLevel -= 1;
//    }
//}
