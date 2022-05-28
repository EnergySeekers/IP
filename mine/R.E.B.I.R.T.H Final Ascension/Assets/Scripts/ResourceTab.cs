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

    public void OpenWoodPanel()
    {
        if (Wood != null)
        {
            bool isActive = Wood.activeSelf;
            Wood.SetActive(!isActive);
        }
    }
    public void OpenStonePanel()
    {
        if (Stone != null)
        {
            bool isActive = Stone.activeSelf;
            Stone.SetActive(!isActive);
        }
    }
    public void OpenCooperPanel()
    {
        if (Cooper != null)
        {
            bool isActive = Cooper.activeSelf;
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
       
        Wood_Production.text = "Wood Production:" + WoodProduction;
        Wood_Intake.text = "Wood Intake:" + WoodIntake;
        Wood_Stock.text = "Wood Intake:" + WoodStock;

        Stone_Production.text = "Stone Production:" + StoneProduction;
        Stone_Intake.text = "Stone Intake:" + StoneIntake;
        Stone_Stock.text = "Stone Intake:" + StoneStock;

        Cooper_Production.text = "Cooper Production:" + CooperProduction;
        Cooper_Intake.text = "Cooper Intake:" + CooperIntake;
        Cooper_Stock.text = "Cooper Intake:" + CooperStock;
    }
}
