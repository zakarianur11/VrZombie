using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ChangeToLevelOne()
    {
        SceneManager.LoadScene("Ravine Mountains");
    }

    public void ChangeToLevelTwo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
} //genuinely where did the other programmer on the team go
