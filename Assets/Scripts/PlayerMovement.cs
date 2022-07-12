using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    //Animator m_Animator;
    //public AudioSource m_AudioSource;


    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;

    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame
    /*void start()
   {
       m_AudioSource=GetComponent<AudioSource>();
   }*/
    void Update()
    {    
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        SceneManager.LoadScene("PauseMenu");
        Cursor.lockState = CursorLockMode.None;
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool hasHorizontalInput = !Mathf.Approximately(x,0f);
        bool hasVerticalInput = !Mathf.Approximately(z,0f);
        bool isWalking = hasHorizontalInput||hasVerticalInput;


        Vector3 move = transform.right * x + transform.forward * z;
        /*if(isWalking)
        {
            if(!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop();
        }*/

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); 
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}