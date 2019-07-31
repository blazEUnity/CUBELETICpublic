using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class onCollAudio : MonoBehaviour
{


    public AudioSource audioDeath;
    // Start is called before the first frame update
    void Start()
    {
        audioDeath = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Obs")
        {
            audioDeath.Play();
        }
    }
}
