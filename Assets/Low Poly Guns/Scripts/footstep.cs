using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isWalking)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
