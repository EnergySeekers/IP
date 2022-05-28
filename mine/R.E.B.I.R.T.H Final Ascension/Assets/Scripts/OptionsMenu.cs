using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject OptionsPanel;
    // Start is called before the first frame update
    
    public void OpenOptionsPanel()
    {
        if(OptionsPanel != null)
        {
            bool isActive = OptionsPanel.activeSelf;
            OptionsPanel.SetActive(!isActive);
        }
    }
}

