using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    private float uziShootRate = 0.2f;

    // I override the ShootRate via a property because I can't overide varibles
    public override float ShootRate
    {
        get { return uziShootRate; }
        protected set { uziShootRate = value; }
    }

    // I override the update in order to enable a end less fire
    protected override void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ShootBullet();
        }
    }
}
