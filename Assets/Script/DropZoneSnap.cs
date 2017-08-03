using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneSnap : MonoBehaviour
{
    public GameObject highLightZone;
    public Material highLightMaterial;
    GameObject m_highLightZone;
	// Use this for initialization
	void Start ()
    {
        m_highLightZone = highLightZone;
        m_highLightZone.GetComponent<MeshRenderer>().material = highLightMaterial;
        m_highLightZone.transform.SetParent(transform);
        m_highLightZone.SetActive(false);
    }
	
    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.CompareTag("Interactable"))
        {
            m_highLightZone.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Interactable"))
        {
            m_highLightZone.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update ()
    {

	}
}
