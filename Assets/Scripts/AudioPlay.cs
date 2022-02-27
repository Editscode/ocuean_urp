using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    public void Play()
    {
        if (audio != null & AudioConfig.AudioItsOn)
        {
            audio.Play();

        }
    }

}
