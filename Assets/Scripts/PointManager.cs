using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public int Points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Points = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Basketball")
        {
            Points += 1;
        }
    }

}