using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiEnemy : Tower
{
    private List<Transform> _target = new List<Transform>();

    protected override void Shoot()
    {
        print("Shooting multiple enemies");
    }

    protected override bool HasTarget()
    {
        bool _return = false;
        // logica voor targetting singleEnemy
        var cols = Physics.OverlapSphere(transform.position, _radius, _layer);

        if (cols.Length > 0)
        {
            _return = true;
        }
        
        return _return;
    }
}
