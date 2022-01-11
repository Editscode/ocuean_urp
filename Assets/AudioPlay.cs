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
    }
    public void Play()
    {

        if (audioListener.enabled & audio != null)
        {
            audio.Play();
        }
    }

}
