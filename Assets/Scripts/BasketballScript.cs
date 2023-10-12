using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasketballScript : MonoBehaviour
{
    MeshRenderer mr;
    SphereCollider sc;
    ParticleSystem ps;
    Rigidbody rb;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        sc = GetComponent<SphereCollider>();
        ps = GetComponentInChildren<ParticleSystem>();
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, -5, 0);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PointDetector")
        {
            StartCoroutine(Db(3f));
            //components
            mr.enabled = false;
            sc.isTrigger = true;
            rb.isKinematic = true;
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
