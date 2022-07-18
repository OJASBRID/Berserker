
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    //Animator m_Animator;

    public GameObject pauseMenu;
    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;
    public bool isWalking;

    Vector3 velocity;
    
    // Update is called once per frame
    
    void Update()
    {
      /*  if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }*/
            

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

        /*if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); 
        }*/

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
    }
}