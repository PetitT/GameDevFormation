using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpawn : MonoBehaviour
{
    public GameObject ennemy;
    public float timeToSpawn;

    private void Start()
    {
        StartCoroutine("spawn");
    }

    private IEnumerator spawn()
    {
        Instantiate(ennemy, transform.position, transform.rotation);
        yield return new WaitForSeconds(timeToSpawn);
        StartCoroutine(spawn());
    }
}
