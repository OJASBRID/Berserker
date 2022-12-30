using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour
{
    public Rigidbody rb;
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude >= 0.3f)
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
