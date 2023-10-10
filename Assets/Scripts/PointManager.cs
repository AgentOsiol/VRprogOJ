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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball") && !other.attachedRigidbody.isKinematic)
        {
            Points += 1;
            Debug.Log(Points);
        }
    }

}