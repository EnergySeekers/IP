using UnityEngine;
using UnityEngine.UI;

public class Trees : MonoBehaviour
{
    public double tree;
    public Text treeText;

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

    public void Click()
    {
        if(Random.Range(1.0f, 100.0f) > 95.0f)
        {
            tree += 1;
        }

    }
}
