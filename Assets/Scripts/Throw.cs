using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    public void Hold()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<SphereCollider>().enabled = false;
    }
    public void ThrowBall()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;

    }
}



