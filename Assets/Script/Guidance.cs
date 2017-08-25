using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class Guidance : MonoBehaviour
{
    public void OnTriggerStay(Collider collider)
    {
        NVRInteractableItem item = collider.gameObject.GetComponent<NVRInteractableItem>();
        Rigidbody rigid = item.gameObject.GetComponent<Rigidbody>();
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, item.transform.position.z);
        rigid.position = pos;
        rigid.rotation = transform.rotation;
    }
}
