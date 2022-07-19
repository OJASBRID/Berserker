using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float score;
    public float multiplier1;
    public float multiplier2;
    public float multiplier3;
    public static float givescore;


    private void Start()
    {
        givescore = 0;
    }
    void Update()
    {
        score = score - multiplier1*Time.deltaTime;
        givescore = score ;
        if(score <= 0f)
        {
            SceneManager.LoadScene("EndPage");
        }
    }

    public void Shoot1()
    {
        score = score + multiplier2;
        
    }

    public void Shoot2()
    {
        score = score + multiplier3;

    }
}
