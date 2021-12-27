using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSize : MonoBehaviour
{
    RectTransform rectTransform;
    public TextMeshProUGUI text;
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void GetActive(bool a)
    {
        if (a)
        {
            rectTransform.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            Debug.Log(rectTransform.transform.localScale);
            text.color = new Color(255, 255, 255, 255);


        }
        else
        {
            rectTransform.transform.localScale = new Vector3(1f, 1f, 1f);
            Debug.Log(rectTransform.transform.localScale);
            text.color = new Color(0, 0, 0, 255);
        }
    }
}

