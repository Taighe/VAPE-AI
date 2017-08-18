using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
using VapeEvents;

public class Attachable : Condition
{
    NVRAttachJoint m_joint;
    void Start()
    {
        m_joint = GetComponent<NVRAttachJoint>();
    }

    void Update()
    {
        if(m_joint.IsAttached)
        {
            OnConditionFulfilled(new ConditionEventArgs(name));
        }
    }

    public void Action()
    {

    }
}
