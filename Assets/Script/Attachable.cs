using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
using VapeEvents;
using UnityEngine.UI;

public class Attachable : Condition
{
    NVRAttachJoint m_joint;

    void Start()
    {
        m_joint = GetComponent<NVRAttachJoint>();
        NVRCustomEvents.OnAttached += Trigger;
        
    }

    void Update()
    {
        
    }

    public void Trigger(object sender, AttachEventArgs e)
    {
        if(e.Item.gameObject.CompareTag(gameObject.tag))
        {
            OnConditionFulfilled(new ConditionEventArgs(e.Name));
            NVRCustomEvents.OnAttached -= Trigger;
        }
    }
}
