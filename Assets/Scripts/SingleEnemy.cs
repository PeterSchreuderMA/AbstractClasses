﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleEnemy : Tower
{
    private Transform _target;

    protected override void Shoot()
    {
        print("Shooting single enemy");
    }

    protected override bool HasTarget()
    {
        bool _return = false;
        // logica voor targetting singleEnemy
        var cols = Physics.OverlapSphere(transform.position, _radius, _layer);

        if (cols.Length > 0)
        {
            _target = cols[0].transform;
            _return = true;
        }

        return _return;
    }
}