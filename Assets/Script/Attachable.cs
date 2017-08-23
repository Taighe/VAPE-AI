using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
using VapeEvents;
using UnityEngine.UI;

public class Attachable : Condition
{
    NVRAttachPoint m_point;
    public Text computerText; 

    void Start()
    {
        m_point = GetComponent<NVRAttachPoint>();
    }

    void Update()
    {
        if(m_point.IsAttached)
        {
            if(m_point.)
            {
                OnConditionFulfilled(new ConditionEventArgs(name));
            }
        }
    }

    public void Action()
    {
        
    }
}
