using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Bullet spawnpoint
    public Transform gunPoint;
    public GameObject bulletPrefab;
    // Force added to bullet
    public float bulletspeed = 15f;
    // Delay until bullet deletes
    public float delay = 5f;
    //Time Between Shoots
    [SerializeField] private float rateOfRire = 1;
    private float waitTime;
    //Ammo Related 
    public int playerAmmo;
    private int ammoCrate = 20;

    void Update()
    {
        // Shoot when fire button is pressed
        if (Input.GetButtonDown("Fire1"))
        {
            if(waitTime < Time.time && playerAmmo > 0)
            {
                Shoot();
                playerAmmo--;
                waitTime = Time.time + rateOfRire;
            }
        }
    }

    void Shoot()
    {
        // Instantiate bullet at the spawnpoint and add an upwards force
        GameObject bullet = Instantiate(bulletPrefab, gunPoint.position, gunPoint.rotation);
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.AddForce(- gunPoint.up * bulletspeed, ForceMode2D.Impulse);
        // Destroy the bullet after the delay
        Object.Destroy(bullet, delay);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ammo Crate"))
        {
            RessuplyAmmo(ammoCrate);
            Destroy(collision.gameObject);
        }
    }

    private void RessuplyAmmo(int ammountToRessuply) //When trigger player ammo goes up.
    {
        playerAmmo += ammountToRessuply;
    }
}