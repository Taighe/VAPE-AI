using UnityEngine;
using System;
using UnityEngine.Events;
namespace VapeEvents
{
    public interface Condition
    {
        void TestCondition();
        event EventHandler ConditionFulfilled;
    }

    public class MyEventArgs : EventArgs
    {
        int m_number;
        public MyEventArgs(int number)
        {
            m_number = number;
        }
        
    }
}
