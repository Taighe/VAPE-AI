using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using VapeEvents;

public class EventTree : MonoBehaviour
{
    public List<VapeEvent> events;

    void Start()
    {
        if(events.Count > 0)
        {
            Condition _obj = (Condition)events[0].conditions.GetPersistentTarget(0);
            
            //Debug.Log(_obj.TestCondition());
        }
        
    }

    void OnEnable()
    {
        //EventManager.StartListening("test", someListener);
    }

}