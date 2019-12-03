using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStaticPosition : MonoBehaviour
{
    public static PlayerStaticPosition instance;
    [HideInInspector] public Vector3 position;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

    private void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        position = transform.position;
    }
}
