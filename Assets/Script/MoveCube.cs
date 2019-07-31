using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float t = 10f; 
    public float l = 10f; 
    public float posX = 10f ;
    public Transform position;

    void Update()
    {
        Vector3 pos = new Vector3(posX+Mathf.PingPong(t * Time.timeSinceLevelLoad, l), position.position.y, position.position.z);
        transform.position = pos;
    }
}
