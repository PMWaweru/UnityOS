using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // Replace with your game scene name
    }

    public void OpenSettings()
    {
        // Load settings scene or enable settings panel
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
