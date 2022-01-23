using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetPhotoDate : MonoBehaviour
{
    public Animator animator;
    public SpawnManagerScriptableObject[] imagesData;
    public Image[] point;
    private int start = 0;
    public Animator styleAnimator;
    public TextMeshProUGUI text;

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
            if (styleAnimator!= null)
            {
                styleAnimator.Play("Expand");
            }
            //text.text = imagesData[j].prefabName;
            animator.SetTrigger("PhotoMove");
            start = j;
        }

    }
}
