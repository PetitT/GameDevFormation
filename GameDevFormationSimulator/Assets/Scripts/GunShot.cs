using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootOrigin;
    public Transform shootDirection;
    public float projectileSpeed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    private void Shoot()
    {
        GameObject mun = Instantiate(projectile, shootOrigin.position, Quaternion.identity);
        mun.transform.LookAt(shootDirection);
        mun.GetComponent<ProjectileBehaviour>().speed = projectileSpeed;
    }
}
