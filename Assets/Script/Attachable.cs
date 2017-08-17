using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
using VapeEvents;

public class Attachable : Condition
{
    NVRInteractableItem m_interactable;
    void Start()
    {
        m_interactable = GetComponent<NVRInteractableItem>();
    }

    void Update()
    {
        if(m_interactable.IsAttached)
        {
            OnConditionFulfilled(new ConditionEventArgs(name));
        }
    }
}
