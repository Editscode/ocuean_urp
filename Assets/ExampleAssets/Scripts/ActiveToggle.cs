using UnityEngine;

public class ActiveToggle : MonoBehaviour
{
    [SerializeField] private GameObject bigTextActive;
    [SerializeField] private GameObject tinyTextActive;
    public void Activate(bool active)
    {
        bigTextActive.SetActive(!active);
        tinyTextActive.SetActive(active);
    }

}
