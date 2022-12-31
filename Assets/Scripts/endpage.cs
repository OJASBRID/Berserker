
using UnityEngine;
using UnityEngine.SceneManagement;

public class endpage : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("EditableSS");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("IntroPage");
    }
}
