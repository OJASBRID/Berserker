using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDest : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {

            Destroy(gameObject);
        }

    }

   
}
