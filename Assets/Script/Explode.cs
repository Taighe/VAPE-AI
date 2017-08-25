using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VapeEvents;

public class Explode : Action
{
    public void StartExplosion()
    {
        BroadcastMessage("Explode");
        GameObject.Destroy(gameObject);
    }
}
