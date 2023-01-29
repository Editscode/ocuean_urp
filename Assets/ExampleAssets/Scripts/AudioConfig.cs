using UnityEngine;

public class AudioConfig : MonoBehaviour
{
    public static bool AudioItsOn { get; set; } = true;

    [SerializeField] private AudioSource[] allAudioSources;

    void Awake()
    {
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
