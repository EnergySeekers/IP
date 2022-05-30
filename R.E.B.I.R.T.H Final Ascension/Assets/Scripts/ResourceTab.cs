using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceTab : MonoBehaviour
{
    public GameObject Wood;
    public GameObject Stone;
    public GameObject Cooper;

    public double WoodProduction;
    public double StoneProduction;
    public double CooperProduction;

    public double WoodIntake;
    public double StoneIntake;
    public double CooperIntake;

    public double WoodStock;
    public double StoneStock;
    public double CooperStock;

    public Text Wood_Production;
    public Text Wood_Intake;
    public Text Wood_Stock;

    public Text Stone_Production;
    public Text Stone_Intake;
    public Text Stone_Stock;

    public Text Cooper_Production;
    public Text Cooper_Intake;
    public Text Cooper_Stock;

    // Start is called before the first frame update
    public int var = 0;

    public void OpenWoodPanel()
    {
        bool isActive = Wood.activeSelf;

        if (Wood != null && (var == 0 || var == 1))
        {
            var = 1;
            Wood.SetActive(!isActive);
        }
        if (var != 0 && var != 1)
        {
            if (var == 2)
                Stone.SetActive(isActive);
            if (var == 3)
                Cooper.SetActive(isActive);

            var = 1;
            Wood.SetActive(!isActive);
        }

    }
    public void OpenStonePanel()
    {
        bool isActive = Stone.activeSelf;

        if (Stone != null && (var == 0 || var == 2))
        {
            var = 2;
            Stone.SetActive(!isActive);
        }
        if (var != 0 && var != 2)
        {
            if (var == 1)
                Wood.SetActive(isActive);
            if (var == 3)
                Cooper.SetActive(isActive);

            var = 2;
            Stone.SetActive(!isActive);
        }
    }
    public void OpenCooperPanel()
    {
        bool isActive = Cooper.activeSelf;

        if (Cooper != null && (var == 0 || var == 3))
        {
            var = 3;
            Cooper.SetActive(!isActive);
        }
        if (var != 0 && var != 3)
        {
            if (var == 1)
                Wood.SetActive(isActive);
            if (var == 2)
                Stone.SetActive(isActive);

            var = 3;
            Cooper.SetActive(!isActive);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Wood_Production.text = "Wood Production: " + WoodProduction;
        Wood_Intake.text = "Wood Intake:         " + WoodIntake;
        Wood_Stock.text = "Wood Stocks:        " + WoodStock;

        Stone_Production.text = "Stone Production: " + StoneProduction;
        Stone_Intake.text = "Stone Intake:         " + StoneIntake;
        Stone_Stock.text = "Stone Stocks:        " + StoneStock;

        Cooper_Production.text = "Cooper Production: " + CooperProduction;
        Cooper_Intake.text = "Cooper Intake:         " + CooperIntake;
        Cooper_Stock.text = "Cooper Stocks:        " + CooperStock;
    }
}
