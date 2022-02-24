using UnityEngine;

public class OpenActivity : MonoBehaviour
{
    public GameObject ActiveEU, ActiveRU;
    private Animator m_AnimatorControllerModel;
    public void Open(bool togle = true)
    {
        if (togle)
        {
            if (ImageSwitch.language)
            {
                ActiveRU.SetActive(true);
                ActiveRU.GetComponent<Animator>().Play("Open");
            }
            else
            {
                ActiveEU.SetActive(true);
                ActiveEU.GetComponent<Animator>().Play("Open");
            }
        }
    }
}
