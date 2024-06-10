using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform gunBarrel;
    public GameObject bulletPrefab;
    public float bulletSpeed = 30f;
    public float fireRate = 0.5f;
    private float nextFireTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) & nextFireTime.time >= nextFireTime

        {

            Shoot();
            nextFireTime = nextFireTime.time + 1f / fireRate;
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        if (buletRB !=null)
        {
            bulletRb.velocity = gunBarrel.forward * bulletSpeed;
        }
        else
        {
            Debug.LogError("Bullet prefab does not have rigidbody")
        }
    }
}
