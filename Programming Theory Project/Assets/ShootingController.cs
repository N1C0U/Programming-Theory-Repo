using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bullet;
    public Transform gun;
    public float shootRate;
    public float shootForce;
    private float m_shootRateTimeStamp;
    Animator m_Animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > m_shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                bullet, gun.position, gun.rotation);

                go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                m_shootRateTimeStamp = Time.time + shootRate;
            }

        }

    }

}
