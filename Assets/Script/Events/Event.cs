using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

namespace VapeEvents
{
    [System.Serializable]
    public class VapeEvent
    {
        public Condition conditions;
        public UnityEvent actions;
        VapeEvent m_nextEvent;
        VapeEvent m_prevEvent;

        public VapeEvent NextEvent
        {
            get
            {
                return m_nextEvent;
            }
            set
            {
                m_nextEvent = value;
            }
        }
        public VapeEvent PrevEvent
        {
            get
            {
                return m_prevEvent;
            }
            set
            {
                m_prevEvent = value;
            }
        }

        public void Start()
        {
            conditions.ConditionFulfilled += TriggerAction;
        }

        void TriggerAction(object sender, ConditionEventArgs e)
        {
            Debug.Log(e.Name + " condition is true");
            actions.Invoke();
            if (m_nextEvent != null)
                m_nextEvent.Active(true);

            Active(false);

        }

        public void Active(bool value)
        {
            conditions.enabled = value;
            Action _actions = actions.GetPersistentTarget(0) as Action;
            _actions.enabled = value;
        }

        public void LateUpdate()
        {
            
        }
    }
}
