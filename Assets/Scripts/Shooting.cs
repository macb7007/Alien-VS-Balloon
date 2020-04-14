using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Blast;
    public GameObject laserPrefab;
    public float force = 15f;
    Rigidbody2D ribo;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject laser = Instantiate(laserPrefab, Blast.position, Blast.rotation);
        ribo = laser.GetComponent<Rigidbody2D>();
        ribo.AddForce(-Blast.right * force, ForceMode2D.Impulse);
        DestroyObject(ribo.gameObject, 2f);
    }
}
