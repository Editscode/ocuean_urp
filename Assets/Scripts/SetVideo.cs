using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SetVideo : MonoBehaviour
{ 
    public VideoClip[] VideoData;
    public VideoPlayer point;
    private int start = 0;

    // Update is called once per frame
    public void setVideo(int j)
    {
        if (start != j)
        {
            point.clip = VideoData[j];
            point.Play();
            start = j;
        }
    }
}
