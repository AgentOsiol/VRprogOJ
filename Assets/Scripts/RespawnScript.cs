using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject basketball;

    // Update is called once per frame
    void Update()
    {
        GameObject basketballExists = GameObject.Find("Basketball(Clone)");
        if (basketballExists == null)
        {
            Instantiate(basketball, transform.position, Quaternion.identity);
        }
    }
}
