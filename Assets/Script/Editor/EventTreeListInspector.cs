using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VapeEvents;

[CustomEditor(typeof(EventTree))]

public class EventTreeListInspector : Editor
{
    enum displayFieldType { DisplayAsAutomaticFields, DisplayAsCustomizableGUIFields }
    displayFieldType DisplayFieldType;

    EventTree t;
    SerializedObject GetTarget;
    SerializedProperty ThisList;
    int ListSize;

    void OnEnable()
    {
        t = (EventTree)target;
        GetTarget = new SerializedObject(t);
        ThisList = GetTarget.FindProperty("events"); // Find the List in our script and create a refrence of it
    }

    public override void OnInspectorGUI()
    {
        //Update our list

        GetTarget.Update();

        //Choose how to display the list<> Example purposes only
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        //DisplayFieldType = (displayFieldType)EditorGUILayout.EnumPopup("", DisplayFieldType);

        //Resize our list
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Define the list size with a number");
        ListSize = ThisList.arraySize;
        ListSize = EditorGUILayout.IntField("List Size", ListSize);

        if (ListSize != ThisList.arraySize)
        {
            while (ListSize > ThisList.arraySize)
            {
                ThisList.InsertArrayElementAtIndex(ThisList.arraySize);
            }
            while (ListSize < ThisList.arraySize)
            {
                ThisList.DeleteArrayElementAtIndex(ThisList.arraySize - 1);
            }
        }

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Or");
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        //Or add a new item to the List<> with a button
        EditorGUILayout.LabelField("Add New Event");

        if (GUILayout.Button("Add New"))
        {
            t.events.Add(new VapeEvent());
        }

        EditorGUILayout.Space();
        EditorGUILayout.Space();

        //Display our list to the inspector window

        for (int i = 0; i < ThisList.arraySize; i++)
        {
            // Display the property fields in two ways.
            SerializedProperty MyListRef = ThisList.GetArrayElementAtIndex(i);
            SerializedProperty actions = MyListRef.FindPropertyRelative("actions");
            SerializedProperty conditions = MyListRef.FindPropertyRelative("conditions");
            EditorGUILayout.LabelField("Event (" + i + ")");
            // Choose to display automatic or custom field types. This is only for example to help display automatic and custom fields.
            //1. Automatic, No customization <-- Choose me I'm automatic and easy to setup
            EditorGUILayout.PropertyField(conditions);
            EditorGUILayout.PropertyField(actions);
            //EditorGUILayout.LabelField("Automatic Field By Property Type");
            if (GUILayout.Button("Add Event here (" + i.ToString() + ")"))
            {
                ThisList.InsertArrayElementAtIndex(ThisList.arraySize - i);
            }
            // Array fields with remove at index
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            //EditorGUILayout.LabelField("Array Fields");
            EditorGUILayout.Space();

            //Remove this index from the List
            //EditorGUILayout.LabelField("Remove an index from the List<> with a button");
            if (GUILayout.Button("Remove This Event (" + i.ToString() + ")"))
            {
                ThisList.DeleteArrayElementAtIndex(i);
            }
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
        }

        //Apply the changes to our list
        GetTarget.ApplyModifiedProperties();
    }
 
    //public static void Show(SerializedProperty list)
    //{
    //    EditorGUILayout.PropertyField(list);
    //    EditorGUI.indentLevel += 1;
    //    if (list.isExpanded)
    //    {
    //        EditorGUILayout.PropertyField(list.FindPropertyRelative("Array.size"));
    //        for (int i = 0; i < list.arraySize; i++)
    //        {
    //            EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
    //        }
    //    }

    //    EditorGUI.indentLevel -= 1;
    //}
}
