using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator anim;

    public Throw throwScript;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("throw");
        }
    }

    void ThrowTheBall()
    {
        throwScript.ThrowBall();
    }
}

