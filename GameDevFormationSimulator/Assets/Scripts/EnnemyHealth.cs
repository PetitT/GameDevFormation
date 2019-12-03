using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyHealth : MonoBehaviour
{
    public int damagePerSword;
    public int damagePerProjectile;

    public int health;

    public int Health
    {
        get { return health; }
        set
        {
            health = value;
            HealthCheck();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            SwordHit();
        }
        if (other.CompareTag("Projectile"))
        {
            ProjectileHit();
            Destroy(other.gameObject);
        }
    }

    private void ProjectileHit()
    {
        Health -= damagePerProjectile;
    }

    private void SwordHit()
    {
        Health -= damagePerSword;
    }
    private void HealthCheck()
    {
        if (health <= 0)
            Destroy(gameObject);
    }
}
