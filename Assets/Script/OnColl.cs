using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColl : MonoBehaviour
{
    public Move disable;
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obs")
        {
            disable.enabled = false;
            FindObjectOfType<GameMan>().gameOver();
            
        }
    }
}
