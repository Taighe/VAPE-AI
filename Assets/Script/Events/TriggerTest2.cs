using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VapeEvents;

public class TriggerTest2 : Condition
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            OnConditionFulfilled(new ConditionEventArgs(name));
        }
    }

    public void Action()
    {
        Debug.Log("This is another Action called");
    }
}
