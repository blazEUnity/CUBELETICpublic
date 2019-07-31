using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
 
    bool gameOverBool = false;
    public float delayTime=2f;
    public GameObject textCompleteUI;
  

    public void Complete()
    {
        textCompleteUI.SetActive(true);
    }

    

    public void gameOver()
    {
        if (gameOverBool == false)
        {
            Debug.Log("Game Over");
            gameOverBool = true;
            Invoke("GameRestart", delayTime);
        }

    }

    void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
