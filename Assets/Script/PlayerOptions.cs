using UnityEngine;
using UnityEngine.UI;
public class PlayerOptions : MonoBehaviour
{
    public Slider volumeSlider, deathSlider;
    
    int toggleValue;
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
        deathSlider.value = PlayerPrefs.GetFloat("deathVolume");


    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.SetFloat("deathVolume", deathSlider.value);
    }
}
