using DanielLochner.Assets.SimpleScrollSnap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public Transform end;
    public Transform start;
    public float speed;
    public SimpleScrollSnap scroll;
    // Start is called before the first frame update
    void Start()
    {
        _ = scroll.InfiniteScrollingSpacing;


    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = Vector3.Lerp(end.position, start.position, ((float)scroll.CenteredPanel/10));
        _ = scroll.CenteredPanel;
        //float step = speed * Time.deltaTime;
        //if (transform.position == end.position)
        //{
        //    var b = end;
        //    end = start;
        //    start = b;
        //}
        //transform.position = Vector3.MoveTowards(transform.position, end.position, step);
    }
}
