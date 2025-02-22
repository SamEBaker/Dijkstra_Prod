using UnityEngine;
using TMPro;

public class LightSwitch : MonoBehaviour
{
    public GameObject LeftPath;
    public GameObject RightPath;
    public bool rightOn = true;

    public void Switch()
    {
        rightOn = !rightOn;
        LeftPath.SetActive(!rightOn);
        RightPath.SetActive(rightOn);
    }
}
