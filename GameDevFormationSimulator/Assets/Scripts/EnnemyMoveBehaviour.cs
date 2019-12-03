using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyMoveBehaviour : MonoBehaviour
{
    public float moveSpeed;
    public NavMeshAgent nav;
    private Transform target;

    private void Start()
    {
        nav.speed = moveSpeed;
    }

    private void Update()
    {
        if (target)
            nav.SetDestination(target.position);
    }

    public void GetTarget()
    {
        target = PlayerStaticPosition.instance.transform;
    }
}
