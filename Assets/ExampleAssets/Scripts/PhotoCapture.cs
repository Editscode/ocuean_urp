using UnityEngine;

public class PhotoCapture : MonoBehaviour
{
    public int i = 0;
    [ContextMenu("MakeScrenshot")]
    public void MakeScrenshot()
    {
        ScreenCapture.CaptureScreenshot(i + ".jpg", 1);
        i++;
    }

}