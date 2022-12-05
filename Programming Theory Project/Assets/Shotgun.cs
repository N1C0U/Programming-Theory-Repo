using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    private int subBulletsCount = 15;
    private float positionalShotRange = 0.01f;
    private float rotationalShotRange = 0.15f;
    float bulletScale = 0.2f;

    protected override void ShootBullet()
    {
        if (Time.time > m_shootRateTimeStamp)
        {
            for (int i = 0; i < subBulletsCount; i++)
            {
                // Spread the initial position randomly
                Vector3 spreadedShotPosition = weaponHolder.position + new Vector3(
                    Random.Range(-positionalShotRange, positionalShotRange),
                    Random.Range(-positionalShotRange, positionalShotRange),
                    Random.Range(-positionalShotRange, positionalShotRange));

                // Spread the shot angle randomy
                Vector3 directionShotRange = weaponHolder.forward + new Vector3(
                     Random.Range(-rotationalShotRange, rotationalShotRange),
                     Random.Range(-rotationalShotRange, rotationalShotRange),
                     Random.Range(-rotationalShotRange, rotationalShotRange));
                Quaternion newRotation = Quaternion.LookRotation(directionShotRange, Vector3.up);

                GameObject go = (GameObject)Instantiate(bullet, spreadedShotPosition, weaponHolder.rotation);
                go.transform.localScale *= bulletScale;
                go.GetComponent<Rigidbody>().AddForce(directionShotRange.normalized * shootForce);
                m_shootRateTimeStamp = Time.time + ShootRate;
            }
        }
    }
}
