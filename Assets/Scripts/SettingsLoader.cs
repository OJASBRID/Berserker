using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingsLoader : MonoBehaviour

{  public void setbutton()
{
   SceneManager.LoadScene("Settings") ;
}
public void update(){
    if(Input.GetKeyDown(KeyCode.Escape))
    SceneManager.LoadScene("PauseMenu");
}
}



