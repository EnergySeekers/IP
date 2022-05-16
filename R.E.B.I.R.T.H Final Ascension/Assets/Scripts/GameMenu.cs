using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public Text treeText;
    public double tree;

    // Start is called before the first frame update
    void Start()
    {
        tree = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        treeText.text = "Trees: " + tree;
    }

    public void ClickButton()
    {
        if(Random.Range(1.0f, 100.0f) > 95)
        {
            tree++;
        }
    }
}
