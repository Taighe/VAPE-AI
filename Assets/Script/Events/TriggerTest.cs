using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VapeEvents;

public class TriggerTest : Condition
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnConditionFulfilled(new ConditionEventArgs(name));
        }
    }

    public void Action()
    {
        Debug.Log("This is the Action called");
    }
}
