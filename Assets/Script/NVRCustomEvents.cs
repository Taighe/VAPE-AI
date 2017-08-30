using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NewtonVR
{
    public static class NVRCustomEvents
    {
        public delegate void AttachEventHandler(object sender, AttachEventArgs e);
        public static event AttachEventHandler OnAttached;

        public static void OnEventAttached(AttachEventArgs e)
        {
            if (OnAttached != null)
                OnAttached(typeof(NVRCustomEvents), e);
        }
    }

    public class AttachEventArgs : EventArgs
    {
        string m_name;
        NVRInteractableItem m_item;
        public AttachEventArgs(string name, NVRInteractableItem item)
        {
            m_name = name;
            m_item = item;
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public NVRInteractableItem Item
        {
            get
            {
                return m_item;
            }
        }
    }
}
