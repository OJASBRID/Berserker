using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YScore : MonoBehaviour
{
    public Text Scare;
    public int val; 

    private void Start()
    {
        val = (int)Score.givescore;
        Scare.text = "Score :" + val;
        
    }
}
