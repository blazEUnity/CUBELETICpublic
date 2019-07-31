using UnityEngine;

public class OnColiCola : MonoBehaviour
{
    public Rigidbody obsCol;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            obsCol.constraints &= RigidbodyConstraints.FreezeRotation;
            obsCol.constraints &= RigidbodyConstraints.FreezePositionX;
            obsCol.constraints &= RigidbodyConstraints.FreezePositionZ;
        }
    }
   
        
}

