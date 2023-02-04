using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioSource SFXPlayer;

    //AudioClips to play
    public static AudioClip leftClickSFX;
    public static AudioClip closeWindowSFX;
    public static AudioClip emailNotificationSFX;
    public static AudioClip launchAlienSFX;
    public static AudioClip flameEmailSFX;

    public static void leftClick()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = leftClickSFX;
        SFXPlayer.Play();
    }
    public static void closeWindow()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = closeWindowSFX;
        SFXPlayer.Play();
    }
    public static void emailNotification()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = emailNotificationSFX;
        SFXPlayer.Play();
    }
    public static void launchAlien()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = launchAlienSFX;
        SFXPlayer.Play();
    }
    public static void flameEmail()
    {
        SFXPlayer.Stop();
        SFXPlayer.clip = flameEmailSFX;
        SFXPlayer.Play();
    }
}
