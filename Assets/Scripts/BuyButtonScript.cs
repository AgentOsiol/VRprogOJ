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
    //gameobjects
    public GameObject Cap;
    public GameObject Shoeb;
    public GameObject Shoew;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PointManager>();
        bought1 = false;
        bought2 = false;
        bought3 = false;

        Cap.SetActive(false);
        Shoeb.SetActive(false);
        Shoew.SetActive(false);
    }

    public void test()
    {
            if(ItemID == 1 && pm.Points >= 3 && bought1 == false)
            {
                pm.Points -= 3;
                Debug.Log("A");
                bought1 = true;
            }
            else if (ItemID == 2 && pm.Points >= 5 && bought2 == false)
            {
                pm.Points -= 5;
                Debug.Log("B");
                bought2 = true;
            }
            else if (ItemID == 3 && pm.Points >= 5 && bought3 == false)
            {
                pm.Points -= 5;
                Debug.Log("C");
                bought3 = true;
            }
    }

    public void Update()
    {
        if(bought1 == true)
        {
            Cap.SetActive(true);
        }
        else if (bought2 == true)
        {
            Shoeb.SetActive(true);
        }
        else if (bought3 == true)
        {
            Shoew.SetActive(true);
        }

    }
}