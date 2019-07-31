using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform playerMove;
    public Vector3 camVector;
   
    void Update()
    {
        transform.position = playerMove.position + camVector;
    }
}
