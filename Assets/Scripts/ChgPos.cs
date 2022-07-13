using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChgPos : MonoBehaviour
{

    public GameObject player;
    public spawning spawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            spawner.stitch2();
        }
    }
}
