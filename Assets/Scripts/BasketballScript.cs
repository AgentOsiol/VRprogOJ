using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballScript : MonoBehaviour
{
    MeshRenderer mr;
    SphereCollider sc;
    ParticleSystem ps;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        sc = GetComponent<SphereCollider>();
        ps = GetComponent<ParticleSystem>();
    }
    private void OnTriggerEnter(Collider other)
  {
        if(other.gameObject.name == "PointDetector")
        {
            StartCoroutine(Db(3f));
            //components
            mr.enabled = false;
            sc.enabled = false;
            ps.Play();
        }
   }

    public IEnumerator Db(float x)
    {
        yield return new WaitForSeconds(x);
        Debug.Log("destroyed");
        Destroy(gameObject);
    }
}
