using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWindow : MonoBehaviour
{
   public GameObject pauseMenu;
    public GameObject about;
    public bool IsPaused;
    public bool aboutAct;
 
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        IsPaused = true;
        aboutAct = true;
        about.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                ResumeGame();
                IsPaused = false;
            }
            else
            {
                PauseGame();
            }
          
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (aboutAct)
            {
                ResumeGame();
                about.SetActive(false);
                aboutAct = false;
            }
            else
            {
                Time.timeScale = 0f;
                about.SetActive(true);
                IsPaused = false;
                aboutAct = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
        pauseMenu.SetActive(false);

    }
    public void mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("IntroPage");
    }
}
