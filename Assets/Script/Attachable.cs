using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
using VapeEvents;
using UnityEngine.UI;

public class Attachable : Condition
{
    NVRAttachJoint m_joint;
    public Text computerText; 

    void Start()
    {
        m_joint = GetComponent<NVRAttachJoint>();
    }

    void Update()
    {
        if(m_joint.AttachedItem != null)
        {
            if(m_joint.AttachedItem.gameObject.CompareTag("Eyes"))
                OnConditionFulfilled(new ConditionEventArgs(name));
        }
    }

    public void Action()
    {
        
    }
}
