using UnityEngine;
using UnityEngine.UI;

public class SetPhotoDate : MonoBehaviour
{
    public Animator animator;
    public SpawnManagerScriptableObject[] imagesData;
    public Image[] point;
    private int start = 0;
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
    public void SwitchLanguage(bool language)
    {
        if (language)
        {
            ru.SetActive(true);
            eu.SetActive(false);
        }
        else
        {
            ru.SetActive(false);
            eu.SetActive(true);
        }
    }
}
