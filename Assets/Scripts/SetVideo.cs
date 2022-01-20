using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SetVideo : MonoBehaviour
{ 
    public VideoClip[] VideoData;
    public VideoPlayer point;
    private int start = 0;
    public Animator styleAnimator;

    // Update is called once per frame
    public void setVideo(int j)
    {
        if (start != j)
        {
            styleAnimator.Play("Expand");
            point.clip = VideoData[j];
            point.Play();
            start = j;
        }
    }
}
