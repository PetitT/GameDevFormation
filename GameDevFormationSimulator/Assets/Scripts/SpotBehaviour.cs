using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotBehaviour : MonoBehaviour
{
    public float callRadius;
    public LayerMask ennemyMask;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var ennemy in Physics.OverlapSphere(transform.position, callRadius, ennemyMask))
            {
                ennemy.GetComponent<EnnemyMoveBehaviour>().GetTarget();
            } 
        }
    }
}
