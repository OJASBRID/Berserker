using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPlayerMovement : MonoBehaviour
{
    
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    
    public float velocity;
    
    


    void Start()
    {
        
        m_Rigidbody = GetComponent<Rigidbody>();
        m_AudioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("PauseMenu");
            Cursor.lockState = CursorLockMode.None;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }

        }

        else
        {
            m_AudioSource.Stop();
        }

        m_Rigidbody.MovePosition(m_Rigidbody.position + move);

    }

    
       
        
    


}

