using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchMenu : MonoBehaviour
{
    public GameObject ResearchPanel;
    // Start is called before the first frame update

    public void OpenResearchPanel()
    {
        if (ResearchPanel != null)
        {
            bool isActive = ResearchPanel.activeSelf;
            ResearchPanel.SetActive(!isActive);
        }
    }
}
