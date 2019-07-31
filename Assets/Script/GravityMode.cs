using UnityEngine;

public class GravityMode : MonoBehaviour
{
    public Rigidbody playerGrav;
    public void OnTriggerEnter(Collider other)
    {
        playerGrav.constraints = RigidbodyConstraints.FreezePositionY;
    }
}
