using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public float characterhealth;
    public healthUImanager _healthUI;

    private void Start()
    {
        _healthUI= GameObject.Find("Canvas").GetComponent<healthUImanager>();
    }
    public void HealthGain()
    {
        if (characterhealth <= 180f)
        {
            characterhealth += 20f;
        }
        if(characterhealth <= 200f)
        { 
        _healthUI.UpdateHealth(characterhealth);
        }
    }

    public void Damage1()
    {
        characterhealth -= 1f;
        if (characterhealth > 0)
        { 
        _healthUI.UpdateHealth(characterhealth);
        }
    }

    public void Damage2()
    {
        characterhealth -= 2f;
        if (characterhealth > 0)
        { 
        _healthUI.UpdateHealth(characterhealth);
        }
    }

    private void Update()
    {
        if(characterhealth <= 0f)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("EndPage");
        }
    }
}
