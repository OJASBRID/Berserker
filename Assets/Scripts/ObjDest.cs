using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDest : MonoBehaviour
{
    public ArBehaviour arBehaviour1;
    public ArBehaviour arBehaviour2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("halth"))
        {
            Debug.Log(other.gameObject.name);
             if(other.gameObject.name == "Arm(Clone)")
            {
                arBehaviour1.Add();
            }
             else if(other.gameObject.name == "Pm(Clone)")
            {
                arBehaviour2.Add();
            }
             else if(other.gameObject.name == "Health(Clone)")
            {

            }
            Destroy(other.gameObject);
        }

    }

   
}
