using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    
    [Header("Targeting")]
    [SerializeField] protected float _radius;
    [SerializeField] protected LayerMask _layer;

    //Functions
    protected abstract void Shoot();
    protected abstract bool HasTarget();


    private void Update()
    {
        if (HasTarget())
            Shoot();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
