using UnityEngine;

public class AudioConfig : MonoBehaviour
{
    public static bool AudioItsOn { get; set; } = true;

    public AudioListener audioListener;
    public AudioSource[] allAudioSources;

    // Start is called before the first frame update
    void Awake()
    {
        //PauseAllSources();
        AudioListener.volume = 0;
    }

    public void PauseAllSources()
    {
        foreach (AudioSource a in allAudioSources)
        {
            var b = a.GetComponent<AudioPlay>();
            if (!AudioItsOn)
            {
                b.Play();
                AudioListener.volume = 0;
            }
            else
            {
                b.Play();
                AudioListener.volume = 1;
            }
        }

    }
}
