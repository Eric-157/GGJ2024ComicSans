using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public class EnemyShootingA : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject player;
    public float shotDelay;
    public float bulletForce;
    public AudioSource audiosource;
    public UnityEngine.Vector3 newVector;
    public UnityEngine.Vector3 randomVector;

    private void Start()
    {
        player = GameObject.Find("TopDownPlayer");
        bulletForce = 200;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float curPosY = transform.position.y;
        newVector = (player.transform.position - this.transform.position).normalized;
        randomVector = new UnityEngine.Vector3(UnityEngine.Random.Range(-0.5f, 0.5f), UnityEngine.Random.Range(-0.5f, 0f), 0);


        if (shotDelay >= 20)
        {
            Shoot();
            Shoot2();
            audiosource.Play();
            shotDelay = 0;
        }

        else
        {
            shotDelay += 1;
         
        }




    }




    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(newVector * bulletForce, ForceMode2D.Force);
    }

    void Shoot2() 
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(randomVector * bulletForce, ForceMode2D.Force);
    }
}
