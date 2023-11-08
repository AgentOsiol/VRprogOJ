using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

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
        bought1 = false;
        bought2 = false;
        bought3 = false;
    }

    public void test()
    {
            if(ItemID == 1 && pm.Points >= 5 && bought1 == false)
            {
                pm.Points -= 5;
                Debug.Log("A");
                bought1 = true;
            }
            else if (ItemID == 2 && pm.Points >= 10 && bought2 == false)
            {
                pm.Points -= 10;
                Debug.Log("B");
                bought2 = true;
            }
            else if (ItemID == 3 && pm.Points >= 15 && bought3 == false)
            {
                pm.Points -= 15;
                Debug.Log("C");
                bought3 = true;
            }
    }
}