using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform player;
    public static Stage counter;
    private float bulletTime;
    public GameObject Particles;
    public GameObject bulletPrefab;
    public Transform bulletSpawn1;
    public Transform bulletSpawn2;
    public Transform bulletSpawn3;
    public Transform bulletSpawn4;
    public Transform bulletSpawn5;
    public Transform Death;
    public GameObject nl;
    public float enemySpeed;
    public float fireRate = 2f;
    public int health1 = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health1;
        InvokeRepeating("Fire", fireRate, fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        //ShootAtPlayer();


    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn1.position, bulletSpawn1.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30f;
        GameObject bullet1 = Instantiate(bulletPrefab, bulletSpawn2.position, bulletSpawn2.rotation);
        bullet1.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30f;
        GameObject bullet2 = Instantiate(bulletPrefab, bulletSpawn3.position, bulletSpawn3.rotation);
        bullet2.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30f;
        GameObject bullet3 = Instantiate(bulletPrefab, bulletSpawn4.position, bulletSpawn4.rotation);
        bullet3.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30f;
        GameObject bullet4 = Instantiate(bulletPrefab, bulletSpawn5.position, bulletSpawn5.rotation);
        bullet4.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30f;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth == 0)
        {
            Stage.counter += 1;
            Instantiate(Particles, Death.position, Death.rotation);
            Instantiate(nl, Death.position, Death.rotation);

            Destroy(gameObject);
        }
    }
}
