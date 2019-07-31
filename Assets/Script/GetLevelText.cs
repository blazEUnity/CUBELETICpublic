using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetLevelText : MonoBehaviour
{

    public Text levelText;
    public Scene scene;
 
    void Start()
    {
       scene = SceneManager.GetActiveScene();
    }
    // Update is called once per frame
    void Update()
    {
        levelText.text = (scene.buildIndex-1).ToString(); 
    }
}
