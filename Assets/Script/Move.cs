using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public float ySpeed;
    public float xSpeed;



    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, ySpeed)*Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-xSpeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(xSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameMan>().gameOver();
        }
    }
}
