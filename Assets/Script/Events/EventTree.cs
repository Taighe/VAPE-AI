using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using VapeEvents;

public class EventTree : MonoBehaviour
{
    public List<VapeEvent> events = new List<VapeEvent>(0);

    void Start()
    {
        int head = 0;
        int tail = events.Count - 1;
        events[head].Start();
        events[head].Active(true);
        if (head != tail)
        {
            events[head].NextEvent = events[1];
 
            for (int i = 1; i < events.Count - 1; i++)
            {
                events[i].PrevEvent = events[i - 1];
                events[i].NextEvent = events[i + 1];
                events[i].Start();
                events[i].Active(false);
            }

            events[tail].PrevEvent = events[tail - 1];
            events[tail].Start();
            events[tail].Active(false);
        }
    }

    void AddNew()
    {
        events.Add(new VapeEvent());
    }

    void Remove(int index)
    {
        events.RemoveAt(index);
    }

    void OnEnable()
    {
        //EventManager.StartListening("test", someListener);
    }

}