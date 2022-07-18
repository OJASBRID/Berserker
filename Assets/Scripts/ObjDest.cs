using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if( other.gameObject.name == "DoorV2")
        {
            SceneManager.LoadScene("EndPage 1");
        }
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {


        
        {
           
            if (hit.gameObject.name == "Zombie1" || hit.gameObject.name == "Zombie1(Clone)")
            {
               playerLife.Damage1();
            }
            else if (hit.gameObject.name == "Zombie2" || hit.gameObject.name == "Zombie2(Clone)")
            {
                playerLife.Damage2();
            }
        }

    }

}

