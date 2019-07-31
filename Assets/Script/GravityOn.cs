using UnityEngine;

public class GravityOn : MonoBehaviour
{
    public Rigidbody playerGrav;
    public void OnTriggerEnter(Collider other)
    {
        playerGrav.constraints &= RigidbodyConstraints.FreezePositionY;
    }
}
