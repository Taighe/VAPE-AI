using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using NewtonVR;

public class AttachTrigger : MonoBehaviour
{
    public UnityEvent actions;

    public void OnTriggerEnter(Collider collider)
    {
        NVRInteractableItem item = collider.gameObject.GetComponent<NVRInteractableItem>();
        NVRCustomEvents.OnEventAttached(new AttachEventArgs(collider.gameObject.name, item));
        actions.Invoke();
    }
}
