using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using NewtonVR;

public class VapeButton : MonoBehaviour
{
    public UnityEvent action;
    NVRButton m_button;
	
    void Start()
    {
        m_button = GetComponent<NVRButton>();
    }

	void Update ()
    {
		if(m_button.ButtonIsPushed)
        {
            action.Invoke();
        }
	}
}
