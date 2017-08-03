using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;

public class LaserGrab : MonoBehaviour
{
    public Color LineColor;
    public float LineWidth = 0.02f;
    public NVRHand handScript;
    private LineRenderer Line;

    void Awake ()
    {
        Line = this.gameObject.AddComponent<LineRenderer>();
        Line.material = new Material(Shader.Find("Unlit/Color"));
        Line.material.SetColor("_Color", LineColor);
        NVRHelpers.LineRendererSetColor(Line, LineColor, LineColor);
        Line.useWorldSpace = true;
        Line.enabled = false;
    }
	
	// Update is called once per frame
	void LateUpdate()
    {
        Line.enabled = false;
        if (handScript.UseButtonPressed)
        {
            Line.enabled = true;
            Line.material.SetColor("_Color", LineColor);
            NVRHelpers.LineRendererSetColor(Line, LineColor, LineColor);
            NVRHelpers.LineRendererSetWidth(Line, LineWidth, LineWidth);

            RaycastHit hitInfo;
            bool hit = Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, 1000);
            Vector3 endPoint;

            if (hit == true)
            {
                endPoint = hitInfo.point;
                GameObject hitObject = hitInfo.collider.gameObject;
                if(hitObject.CompareTag("Interactable"))
                {
                    hitObject.transform.position = transform.position;
                    hitObject.GetComponent<Rigidbody>().velocity = Vector2.zero;
                }
            }
            else
            {
                endPoint = this.transform.position + (this.transform.forward * 1000f);
            }

            Line.SetPositions(new Vector3[] { this.transform.position, endPoint });
        }
	}
}
