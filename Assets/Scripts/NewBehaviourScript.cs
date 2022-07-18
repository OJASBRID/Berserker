using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damsche : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
}
