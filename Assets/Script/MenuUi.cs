using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUi : MonoBehaviour
{
    public void QuitStart()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SwitchCredits()
    {
        SceneManager.LoadScene("Options");
    }

    public void back()
    {
        SceneManager.LoadScene("StartUI");
    }


}
