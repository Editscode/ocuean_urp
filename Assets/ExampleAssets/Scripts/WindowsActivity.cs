using UnityEngine;

public class WindowsActivity : MonoBehaviour
{
    [SerializeField]
    private Animator m_AnimatorControllerModel;

    bool ActivePanel = false;
    [ContextMenu("OpenPanel")]
    public void OpenPanel()
    {
        if (ActivePanel)
        {
            m_AnimatorControllerModel.Play("Bottom");
            ActivePanel = true;
        }
        else
        {
            m_AnimatorControllerModel.Play("Close");
            ActivePanel = false;
        }
    }
    public void Deactive()
    {
        gameObject.SetActive(false);
    }
}
