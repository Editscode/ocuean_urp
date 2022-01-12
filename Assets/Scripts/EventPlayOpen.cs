using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPlayOpen : MonoBehaviour
{
    [SerializeField]
    private Animator m_AnimatorControllerModel;
    [SerializeField]
    private Animator m_AnimatorControllerCam;
    private bool active = false;



    public void ActiveButton()
    {
        if (active)
        {
            CloseEvent();

            active = false;
        }
        else
        {
            OpenEvent();
            active = true;
        }
    }
    private void OpenEvent()
    {
        m_AnimatorControllerCam.Play("Move");
        m_AnimatorControllerModel.Play("Open");
       
    }

    private void CloseEvent()
    {
        m_AnimatorControllerCam.Play("BackMove");
        m_AnimatorControllerModel.Play("Close");

    }
}
