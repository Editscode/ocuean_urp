using UnityEngine;

public class EventPlayOpen : MonoBehaviour
{
    [SerializeField]
    private Animator m_AnimatorControllerModel;
    [SerializeField]
    private Animator m_AnimatorControllerCam;
    [SerializeField]
    private OpenActivity openActivity;
    private bool active = false;

    public void ActiveButton()
    {
        switch (active)
        {
            case true:
                CloseEvent();
                active = false;
                break;
            default:
                OpenEvent();
                active = true;
                break;
        }
    }
    private void OpenEvent()
    {
        m_AnimatorControllerCam.Play("CamMoveVant");
        m_AnimatorControllerModel.Play("Open");
    }
    private void CloseEvent()
    {
        m_AnimatorControllerCam.Play("BackMove");
        m_AnimatorControllerModel.Play("Close");

    }
    public void TextActivate()
    {
        openActivity.Open();
    }
}
