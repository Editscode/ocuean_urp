using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    private AudioSource audio;

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
