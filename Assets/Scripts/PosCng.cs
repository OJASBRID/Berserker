using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosCng : MonoBehaviour
{
    public GameObject player;
    public spawning spawner;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            spawner.stitch1();
        }
    }
}
