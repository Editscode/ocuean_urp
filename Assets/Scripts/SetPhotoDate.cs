using UnityEngine;
using UnityEngine.UI;

public class SetPhotoDate : MonoBehaviour
{
    public Animator animator;
    public SpawnManagerScriptableObject[] imagesData;
    public Image[] point;
    private int start = 0;
    private bool language = false;
    public GameObject ru, eu;

    // Update is called once per frame
    public void setPhoto(int j)
    {
        if (start != j)
        {
            for (int i = 0; i < point.Length; i++)
            {
                point[i].sprite = imagesData[j].PointsPhoto[i];
                point[i].SetNativeSize();
            }
            animator.SetTrigger("PhotoMove");
            start = j;
        }

    }
    public void SwitchLanguage()
    {
        if (language)
        {
            ru.SetActive(true);
            eu.SetActive(false);
            language = false;
            return;
        }
        ru.SetActive(false);
        eu.SetActive(true);
        language = true;
    }
}
