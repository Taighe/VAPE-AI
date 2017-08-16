using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public void StartExplosion()
    {
        BroadcastMessage("Explode");
        GameObject.Destroy(gameObject);
    }
}
