using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public float characterhealth;
   
    public void HealthGain()
    {
        characterhealth += 20f;
    }

    public void Damage1()
    {
        characterhealth -= 20f;
    }

    public void Damage2()
    {
        characterhealth -= 40f;
    }

    private void Update()
    {
        if(characterhealth <= 0f)
        {
            SceneManager.LoadScene("EndPage");
        }
    }
}
