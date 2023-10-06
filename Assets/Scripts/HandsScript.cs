using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsScript : MonoBehaviour
{

    //Scripts
    PointManager pm;
    BuyButtonScript bts;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PointManager>();
        bts = FindObjectOfType<BuyButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<PointManager>().Points = pm.Points;
        FindObjectOfType<BuyButtonScript>().ItemID = bts.ItemID;

    }
}
