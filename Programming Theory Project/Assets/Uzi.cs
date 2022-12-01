using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    private float uziShootRate = 0.2f;

    public override float ShootRate
    {
        get { return uziShootRate; }
        protected set { uziShootRate = value; }
    }

    protected override void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ShootBullet();
        }
    }
}
