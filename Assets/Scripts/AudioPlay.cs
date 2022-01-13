using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    AudioSource audio;
    public AudioListener audioListener;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        AudioListener.volume = 0;
    }
    public void Play()
    {
        if (audioListener.enabled & audio != null)
        {
            audio.Play();

            AudioListener.volume = 1;
        }
    }
    void PauseAllSources()
    {
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in allAudioSources)
        {
            if (a.isActiveAndEnabled == true)
            {
                if (a.isPlaying) a.Pause();
                else a.UnPause();
            }
        }

    }

}
