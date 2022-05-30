using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachinesLogic : MonoBehaviour
{
    public GameObject CopperForgePanel;
    public GameObject CopperSmithingPanel;
    public GameObject CopperRobotPanel;

    public float timer = 0.0f;
    public float waitTime = 10.0f;

    public double copperOre = 100;
    public double copperIngot = 0;
    public double coal = 20;
    public double copperWire = 0;
    public double copperPipes = 0;
    public double copperContainers = 0;
    public double target = 0;
    public float fillSpeed = 0.5f;
    public bool robocheck = false;
    public int roboNo = 0;


    public Text copperOreText;
    public Text copperIngotTextForge;
    public Text copperIngotTextSmithing;
    public Text coalText;
    public Text copperWireText;
    public Text copperPipesText;
    public Text copperContainersText;
    public Text roboCoalText;
    public Text roboOreText;
    public Text roboNoText;
    //public GameObject buttonToHide;

    public Slider slider;


    public void IncrementProgress(float newProgress)
    {
        target = slider.value + newProgress;
    }

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
    public void OpenCopperRoboPanel()
    {
        if (CopperRobotPanel != null)
        {
            bool isActive = CopperRobotPanel.activeSelf;
            CopperRobotPanel.SetActive(!isActive);
            roboNo = 1;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(0.75f);
/*        buttonToHide = GetComponent<Button>();
        buttonToHide.onClick.AddListener(() => StopRobot());*/
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        copperOreText.text = "Copper Ore: " + copperOre;
        copperIngotTextForge.text = "Copper Ingots: " + copperIngot;
        copperIngotTextSmithing.text = "Copper Ingots: " + copperIngot;
        coalText.text = "Coal: " + coal;
        copperWireText.text = "Copper Wire: " + copperWire;
        copperPipesText.text = "Copper Pipes: " + copperPipes;
        copperContainersText.text = "Copper Containers: " + copperContainers;
        roboCoalText.text = "Coal: " + coal;
        roboOreText.text = "Copper Ore: " + copperOre;
        roboNoText.text = "Robots number: " + roboNo;

        if(robocheck == true)
        {
            if(timer >= waitTime && coal >= 10 * roboNo)
            {
                timer = timer - waitTime;
                coal -= 10 * roboNo;
                copperOre += 10 * roboNo;
                slider.value = 0;
            }
            if (slider.value <= waitTime)
            {
                slider.value += ((waitTime) / 80) * Time.deltaTime;
            }
            if(coal == 0)
            {
                StopRobot();
            }
        }
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
    public void DeployRobot()
    {
        if(coal >= 10)
        {
            robocheck = true;
        }
    }
    public void StopRobot()
    {
        robocheck = false;
        slider.value = 0;
        //buttonToHide.gameObject.setActive(false);
    }

    public void addRobot()
    {
        roboNo += 1;
    }

}
