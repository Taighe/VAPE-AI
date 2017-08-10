using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace VapeEvents
{
    [System.Serializable]
    public struct VapeEvent
    {
        public UnityEvent conditions;
        public UnityEvent actions;

        void Start()
        {

        }

        public void LateUpdate()
        {
            
        }
    }
}
