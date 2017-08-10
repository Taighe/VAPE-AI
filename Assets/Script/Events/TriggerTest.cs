using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VapeEvents;

public class TriggerTest : MonoBehaviour, Condition
{
    public event EventHandler ConditionFulfilled;
    public void TestCondition()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            OnConditionFulfilled(new MyEventArgs(2));
        }          
    }

    protected virtual void OnConditionFulfilled(MyEventArgs e)
    {
        ConditionFulfilled(this, e);
    }

    void Update()
    {
        TestCondition();
    }
}
