using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //AudioSources to use
    public AudioSource SFXPlayer;

    //AudioClips to play
    public AudioClip leftClickSFX;
    public AudioClip closeWindowSFX;
    public AudioClip emailNotificationSFX;
    public AudioClip launchAlienSFX;
    public AudioClip flameEmailSFX;


    public void leftClick()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = leftClickSFX;
        SFXPlayer.Play();
    }
    public void closeWindow()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = closeWindowSFX;
        SFXPlayer.Play();
    }
    public void emailNotification()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = emailNotificationSFX;
        SFXPlayer.Play();
    }
    public void launchAlien()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = launchAlienSFX;
        SFXPlayer.Play();
    }
    public void flameEmail()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = flameEmailSFX;
        SFXPlayer.Play();
    }
}