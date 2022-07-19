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
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("EndPage 1");

        }
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {


        
        {
           
            if ( hit.gameObject.name == "Zombie1(Clone)")
            {  
               playerLife.Damage1();
                Physics.IgnoreCollision(gameObject.GetComponent<Collider>(),hit.gameObject.GetComponent<Collider>());
            }
            else if ( hit.gameObject.name == "Zombie2(Clone)")
            {
                playerLife.Damage2();
                Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), hit.gameObject.GetComponent<Collider>());
            }
        }

    }

}

