using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionManager : MonoBehaviour
{
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        LoadOptions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolBGM(float vol)
    {
        mixer.SetFloat("VolBGM", vol);
    }

    public void ChangeVolSFX(float vol)
    {
        mixer.SetFloat("VolSFX", vol);
    }

    public void SaveOptions()
    {
        float volBGM, volSFX;
        mixer.GetFloat("VolBGM", out volBGM);
        mixer.GetFloat("VolSFX", out volSFX);
        PlayerPrefs.SetFloat("PlayerVolBGM", volBGM);
        PlayerPrefs.SetFloat("PlayerVolSFX", volSFX);
        PlayerPrefs.Save();
    }

    public void LoadOptions()
    {
        float volBGM;
        float volSFX;
        if (PlayerPrefs.HasKey("PlayerVolBGM"))
        {
            volBGM = PlayerPrefs.GetFloat("PlayerVolBGM");
            mixer.SetFloat("VolBGM", volBGM);
        }

        if (PlayerPrefs.HasKey("PlayerVolSFX"))
        {
            volSFX = PlayerPrefs.GetFloat("PlayerVolSFX");
            mixer.SetFloat("VolSFX", volSFX);
        }
    }
}
