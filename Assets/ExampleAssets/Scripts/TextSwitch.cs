using TMPro;
using UnityEngine;
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
    public void Switch(bool switchText)
    {
        if (switchText)
        {
            Text.text = startText;
        }
        else
        {
            Text.text = this.switchText;
        }

    }

}
