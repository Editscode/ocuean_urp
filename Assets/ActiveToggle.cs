using UnityEngine;

public class ActiveToggle : MonoBehaviour
{
    public GameObject bigTextActive;
    public GameObject tinyTextActive;
    public void Activate(bool active)
    {
        bigTextActive.SetActive(!active);
        tinyTextActive.SetActive(active);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
