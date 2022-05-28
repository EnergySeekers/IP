using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachinesLogic : MonoBehaviour
{
    public GameObject CopperForgePanel;
    public GameObject CopperSmithingPanel;

    public double copperOre = 100;
    public double copperIngot = 0;
    public double coal = 100;
    public double copperWire = 0;
    public double copperPipes = 0;
    public double copperContainers = 0;

    public Text copperOreText;
    public Text copperIngotTextForge;
    public Text copperIngotTextSmithing;
    public Text coalText;
    public Text copperWireText;
    public Text copperPipesText;
    public Text copperContainersText;

    // Start is called before the first frame update

    public void OpenCopperForgePanel()
    {
        if (CopperForgePanel != null)
        {
            bool isActive = CopperForgePanel.activeSelf;
            CopperForgePanel.SetActive(!isActive);
        }
    }
    public void OpenCopperSmithingPanel()
    {
        if (CopperSmithingPanel != null)
        {
            bool isActive = CopperSmithingPanel.activeSelf;
            CopperSmithingPanel.SetActive(!isActive);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        copperOreText.text = "Copper Ore: " + copperOre;
        copperIngotTextForge.text = "Copper Ingots: " + copperIngot;
        copperIngotTextSmithing.text = "Copper Ingots: " + copperIngot;
        coalText.text = "Coal: " + coal;
        copperWireText.text = "Copper Wire: " + copperWire;
        copperPipesText.text = "Copper Pipes: " + copperPipes;
        copperContainersText.text = "Copper Containers: " + copperContainers;
    }

    public void ForgeIngot()
    {
        if(coal >= 10 && copperOre >= 5)
        {
            copperIngot += 1;
            copperOre -= 5;
            coal -= 10;
        }
    }
    public void CreateWire()
    {
        if (copperIngot >= 1)
        {
            copperIngot -= 1;
            copperWire += 25;
        }
    }
    public void CreatePipe()
    {
        if (copperIngot >= 1)
        {
            copperIngot -= 1;
            copperPipes += 5;
        }
    }
    public void CreateContainer()
    {
        if (copperIngot >= 1)
        {
            copperIngot -= 1;
            copperContainers += 2;
        }
    }
}
