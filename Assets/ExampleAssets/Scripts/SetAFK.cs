using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetAFK : MonoBehaviour
{
    int IdleTimeSetting = 30;
    float LastIdleTime;
    public GameObject work;
    public GameObject afk;
    void Awake()
    {
        LastIdleTime = Time.time;
    }

    private void FixedUpdate()
    {
        if (Input.anyKey)
        {
            LastIdleTime = Time.time;
            work.SetActive(true);
            afk.SetActive(false);
        }
        if (IdleCheck())
        {
            if (!afk.active)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            //scroll.GoToPanel(0);
            //work.SetActive(false);
            //afk.SetActive(true);
        }
    }

    private bool IdleCheck()
    {
        return Time.time - LastIdleTime > IdleTimeSetting;
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
