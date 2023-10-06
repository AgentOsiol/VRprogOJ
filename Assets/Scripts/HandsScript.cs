using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsScript : MonoBehaviour
{

    //Scripts
    PointManager pointManger;
    ShopSystem shopsystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<PointManager>().Points = pointManger.Points;


    }
}
