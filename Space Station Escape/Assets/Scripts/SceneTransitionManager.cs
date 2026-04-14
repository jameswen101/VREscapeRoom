using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    [SerializeField] private string mainMenuSceneName = "MainMenu";
    [SerializeField] private string gameSceneName = "EscapeRoom";

    public void BackToMain()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void Quit()
    {
       Application.Quit();
    }
}