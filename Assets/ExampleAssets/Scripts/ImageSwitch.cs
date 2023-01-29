using UnityEngine;
using UnityEngine.UI;

public class ImageSwitch : MonoBehaviour
{
    //TODO: Вынести в синглтон языка
    public static bool language { get; set; } = true;
    [SerializeField] private Image image;
    [SerializeField] private Sprite switchImage;
    private Sprite startImage;
    private void Awake()
    {
        image = GetComponent<Image>();
        startImage = GetComponent<Image>().sprite;
    }
    public void Switch(bool switchImage)
    {
        image.sprite = switchImage ? startImage : this.switchImage;
    }

}
