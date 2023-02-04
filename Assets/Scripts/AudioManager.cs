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

    private void Start()
    {
        AudioController.SFXPlayer = SFXPlayer;
        AudioController.leftClickSFX = leftClickSFX;
        AudioController.closeWindowSFX = closeWindowSFX;
        AudioController.emailNotificationSFX = emailNotificationSFX;
        AudioController.launchAlienSFX = launchAlienSFX;
        AudioController.flameEmailSFX = flameEmailSFX;
    }
}