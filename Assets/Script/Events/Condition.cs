using UnityEngine;
using System;
using UnityEngine.Events;

namespace VapeEvents
{
    public class Condition : MonoBehaviour
    {
        public delegate void ConditionEventHandler(object sender, ConditionEventArgs e);
        public event ConditionEventHandler ConditionFulfilled;

        protected virtual void OnConditionFulfilled(ConditionEventArgs e)
        {
            if (ConditionFulfilled != null)
                ConditionFulfilled(this, e);
        }
    }

    public class ConditionEventArgs : EventArgs
    {
        string m_name;
        public ConditionEventArgs(string name)
        {
            m_name = name;
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }
       
    }
}
