using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    
    public AudioMixer audioMix;
    public AudioMixer audioDeath;

    public void SetVolume(float volume)
    {
        audioMix.SetFloat("volume", volume);

    }

    public void SetDeathVolume(float death)
    {
        audioDeath.SetFloat("deathVolume", death);

    }



    public void FullScreen (bool isToogled)
    {
        Screen.fullScreen = isToogled;
    }
}
