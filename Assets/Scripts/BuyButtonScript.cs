using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BuyButtonScript : MonoBehaviour
{
    //Scripts
    PointManager pointManger;
    ShopSystem shopsystem;
    //ItemID
    public int ItemID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hands")
        {
            if(ItemID == 1 && GetComponent<PointManager>().Points < 10)
            {
                GetComponent<PointManager>().Points -= 10;
                Debug.Log("A");
            }
            else if (ItemID == 2 && GetComponent<PointManager>().Points < 15)
            {
                GetComponent<PointManager>().Points -= 15;
            }
            else if (ItemID == 3 && GetComponent<PointManager>().Points < 30) 
            {
                GetComponent<PointManager>().Points -= 30;
            }
        }
        
            
        
    }
}

