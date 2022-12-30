using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 MoveDirection;

    public Rigidbody rb;


    void Start()
    {
        rb.freezeRotation= true;
    }

    // Update is called once per frame

    private void myInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void Update()
    {
        myInput();
        speedControl(); 
    }

    private void Moveplayer()
    {
        MoveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(MoveDirection.normalized * movespeed * 10f, ForceMode.Force);
        MoveDirection = new Vector3(0, 0, 0);
    }

    private void FixedUpdate()
    {
        Moveplayer();
    }

    private void speedControl()
    {
        Vector3 flatvel = new Vector3(rb.velocity.x,0,rb.velocity.z);

        if(flatvel.magnitude > movespeed)
        {
            Vector3 limvel = flatvel.normalized * movespeed;

            rb.velocity = limvel;
        }
    }
}

