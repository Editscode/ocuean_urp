using TMPro;
using UnityEngine;

public class AudioTextSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public TextMeshProUGUI Text;
    public bool language { get; set; } = true;
    public string[] TextCase = new string[] {
    "«вук: выкл",
    "«вук: вкл",
    "Sound: on",
    "Sound: off"
    };
    bool switchimage = true;
    public void Switch(bool switchimage)
    {
        if (language)
        {


            if (switchimage)
            {
                Text.text = TextCase[0];
            }
            else
            {
                Text.text = TextCase[1];
            }
        }
        else
        {
            if (switchimage)
            {
                Text.text = TextCase[2];
            }
            else
            {
                Text.text = TextCase[3];
            }
        }
        this.switchimage = switchimage;

    }
    public void UpdateText()
    {
        Switch(switchimage);
    }
}

