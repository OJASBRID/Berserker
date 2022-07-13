using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDest : MonoBehaviour
{
    public ArBehaviour arBehaviour1;
    public ArBehaviour arBehaviour2;
    public PlayerLife playerLife;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("halth"))
        {

            if (other.gameObject.name == "Arm(Clone)")
            {
                arBehaviour1.Add();
            }
            else if (other.gameObject.name == "Pm(Clone)")
            {
                arBehaviour2.Add();
            }
            else if (other.gameObject.name == "Health(Clone)")
            {
                playerLife.HealthGain();
            }
            Destroy(other.gameObject);
        }
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {


        if (hit.gameObject.CompareTag("ayenime"))
        {
            Debug.Log(hit.gameObject.name);
            if (hit.gameObject.name == "Zombie1")
            {
               playerLife.Damage1();
            }
            else if (hit.gameObject.name == "Zombie2")
            {
                playerLife.Damage2();
            }
        }

    }

}

