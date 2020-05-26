﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultishotWeapon : Weapon
{
    float degree = .1f;

    protected override void Shoot(ProjectilePool pool, Vector3 position,  Vector3 direction){
        pool.GetProjectile(this._transform.position, direction);
        pool.GetProjectile(this._transform.position, direction.Rotate(20f));
        pool.GetProjectile(this._transform.position, direction.Rotate(-20f));
    }
}


