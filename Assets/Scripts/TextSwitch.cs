using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextSwitch : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI Text;

    public string switchText;
    private string startText;
    private void Awake()
    {
        startText = Text.text;
    }
    public void Switch(bool switchimage)
    {
        if (switchimage)
        {
            Text.text = startText;
        }
        else
        {
            Text.text = switchText;
        }

    }

}
