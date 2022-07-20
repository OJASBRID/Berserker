using System.Collections;

using UnityEngine;

public class Lamplight : MonoBehaviour
{
    public GameObject Lamp;
    public float time;
    void Start()
    {


        StartCoroutine(Flicker());

    }

    // Update is called once per frame
    IEnumerator Flicker()
    {

        Light Bulb = Lamp.GetComponentInChildren<Light>();
        while (true)
        {
            Bulb.enabled = true;
            yield return new WaitForSeconds(time);
            Bulb.enabled = false;
            yield return new WaitForSeconds(time);

        }
    }
}
