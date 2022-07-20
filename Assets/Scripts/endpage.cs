
using UnityEngine;
using UnityEngine.SceneManagement;

public class endpage : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("IntroPage");
    }
}
