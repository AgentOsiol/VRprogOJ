using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BuyButtonScript : MonoBehaviour
{
    //Scripts
    PointManager pm;
    //ItemID
    public int ItemID;
    //truefalse
    bool bought1;
    bool bought2;
    bool bought3;

    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hands")
        {
            if(ItemID == 1 && pm.Points >= 10 && bought1 == false)
            {
                pm.Points -= 10;
                Debug.Log("A");
            }
            else if (ItemID == 2 && pm.Points >= 15)
            {
                pm.Points -= 15;
            }
            else if (ItemID == 3 && pm.Points >= 30) 
            {
                pm.Points -= 30;
            }
        }
        
    }
}

