using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
   public void Button1()
{
SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
}
}
