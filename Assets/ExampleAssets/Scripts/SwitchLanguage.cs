using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLanguage : MonoBehaviour
{
    public GameObject ru, eu;
    public void Switch(bool language)
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
