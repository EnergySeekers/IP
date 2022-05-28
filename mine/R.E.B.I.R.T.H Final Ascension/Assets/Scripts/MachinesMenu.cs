using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachinesMenu : MonoBehaviour
{
    public GameObject MachinePanel;
    // Start is called before the first frame update

    public void OpenMachinePanel()
    {
        if (MachinePanel != null)
        {
            bool isActive = MachinePanel.activeSelf;
            MachinePanel.SetActive(!isActive);
        }
    }
}
