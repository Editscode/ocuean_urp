using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���� ��������� ���� ��������
/// </summary>

public class AwaitActivity : MonoBehaviour
{
    public GameObject[] gameObjects;
    void Awake()
    {
        foreach (var item in gameObjects)
        {
            item.SetActive(true);
            item.SetActive(false);
        }
    }

}
