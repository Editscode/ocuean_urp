using TMPro;
using UnityEngine;

public class ToggleSize : MonoBehaviour
{
    RectTransform rectTransform;
    [SerializeField] private TextMeshProUGUI text;
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void GetActive(bool activate)
    {
        if (!activate)
        {
            rectTransform.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            text.color = new Color(0, 0, 0, 255);
        }
        else
        {
            rectTransform.transform.localScale = new Vector3(1f, 1f, 1f);
            text.color = new Color(255, 255, 255, 255);
        }
    }
}

