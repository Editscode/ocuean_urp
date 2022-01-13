using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitch : MonoBehaviour
{

    public static bool language { get; set; }= true;
    [SerializeField]
    private Image image;

    public Sprite switchImage;
    private Sprite startImage;
    private void Awake()
    {
        image = GetComponent<Image>();
        startImage = GetComponent<Image>().sprite;
    }
    public void Switch(bool switchimage)
    {
        if (switchimage)
        {
            image.sprite = startImage;
        }
        else
        {
            image.sprite = switchImage;
        }
       
    }


}
