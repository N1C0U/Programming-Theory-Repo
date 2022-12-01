using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform weaponHolder;

    public float shootForce;
    private float m_shootRateTimeStamp;

    private float shootRate = 0;

    public virtual float ShootRate 
    {
        get { return shootRate; }
        protected set { shootRate = value; } 
    }

    protected virtual void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    protected virtual void ShootBullet()
    {
        if (Time.time > m_shootRateTimeStamp)
        {
            GameObject go = (GameObject)Instantiate(
            bullet, weaponHolder.position, weaponHolder.rotation);

            go.GetComponent<Rigidbody>().AddForce(weaponHolder.forward * shootForce);
            m_shootRateTimeStamp = Time.time + ShootRate;
        }
    }

}
