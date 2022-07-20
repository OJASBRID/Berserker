
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadHelp()
    {
        SceneManager.LoadScene("HelpPage");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("IntroPage");
    }
}
