using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamplight : MonoBehaviour
{
    public GameObject[] lamps;
    void Start()
    {
       StartCoroutine(LampUse()); 
    }

    // Update is called once per frame
    private IEnumerator LampUse()
    {
        for (int i = 0; i < 19; i++)
        {
            while (true)
            {
                //lamps[i].GetComponentsInChildren<Light>().enabled = true;
                yield return new WaitForSeconds(Random.Range(0.02f, 0.2f));
              //  lamps[i].GetComponentsInChildren<Light>().enabled = false;
                yield return new WaitForSeconds(Random.Range(0.02f, 0.2f));
            }
        }
    }
}
