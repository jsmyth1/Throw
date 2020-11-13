using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAnim : MonoBehaviour
{
    public Animator Ani;

    bool Throw = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Throw = true;
            Ani.SetBool("throw", true);
        }

        else if (Input.GetKeyUp(KeyCode.T))
        {
            Throw = false;
            Ani.SetBool("throw", false);
        }
    }
}