using UnityEngine;
public class TriggerEnd : MonoBehaviour
{
    public GameMan endGame;
     void OnTriggerEnter()
    {
        endGame.Complete();
        
    }
}
