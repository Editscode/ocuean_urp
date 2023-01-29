using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetPhotoDate : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpawnManagerScriptableObject[] imagesData;
    [SerializeField] private Image[] point;
    private int start = 0;
    public Animator styleAnimator;
    public void SetPhoto(int j)
    {
        if (start != j)
        {
            for (int i = 0; i < point.Length; i++)
            {
                point[i].sprite = imagesData[j].PointsPhoto[i];
                point[i].SetNativeSize();
            }
            if (styleAnimator != null)
            {
                styleAnimator.Play("Expand");
            }
            //text.text = imagesData[j].prefabName;
            animator.SetTrigger("PhotoMove");
            start = j;
        }

    }
}
