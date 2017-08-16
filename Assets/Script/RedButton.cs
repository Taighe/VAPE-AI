using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VapeEvents;

public class RedButton : Condition
{
    public NewtonVR.NVRButton nvr_button;

	void Update ()
    {
		if(nvr_button.ButtonDown)
        {
            OnConditionFulfilled(new ConditionEventArgs(name));
        }
	}

    public void Action()
    {
        BroadcastMessage("Explode");
    }
}
