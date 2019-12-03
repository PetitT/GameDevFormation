using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Animator anim;

    private void Update()
    {
        SwordSlash();
    }

    private void SwordSlash()
    {
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetTrigger("Attack");
        }
    }
}
