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
    public void Switch(bool switchLanguageAudioText)
    {
        Text.text = language ? switchLanguageAudioText ? TextCase[0] : TextCase[1] : switchLanguageAudioText ? TextCase[2] : TextCase[3];
        this.switchimage = switchLanguageAudioText;
    }
    public void UpdateText()
    {
        Switch(switchimage);
    }
}

