using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesMenu : MonoBehaviour
{
    public GameObject ResourcePanel;
    // Start is called before the first frame update

    public void OpenResourcePanel()
    {
        if (ResourcePanel != null)
        {
            bool isActive = ResourcePanel.activeSelf;
            ResourcePanel.SetActive(!isActive);
        }
    }
}
