
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
   

    public GameObject pauseMenu;
    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;
    public bool isWalking;

    Vector3 velocity;
    
    
    
    void Update()
    {
      
            

        if(controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool hasHorizontalInput = !Mathf.Approximately(x,0f);
        bool hasVerticalInput = !Mathf.Approximately(z,0f);
        isWalking = hasHorizontalInput||hasVerticalInput;


        Vector3 move = transform.right * x + transform.forward * z;
        

        controller.Move(move * speed * Time.deltaTime);

        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
    }
}