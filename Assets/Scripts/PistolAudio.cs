using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public WeaponSwitch weaponSwitch;
    public ArBehaviour ar;
    private bool weapan;
    private bool aumo;

    

    private void Update()
    {    
        if((ar.totalammo + ar.currentAmmo) == 0)
        {
            aumo = false;
        }
        else
        {
            aumo = true;
        }

        if(weaponSwitch.weaponNo == 1)
        {
            weapan = true;
        }
        else
        {
            weapan = false;
        }


        if(weapan && Input.GetButtonDown("Fire1") && aumo)
        {
            audioSource.Play();
        }
    }
}
