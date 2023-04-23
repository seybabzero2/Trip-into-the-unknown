using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowing : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform player;
    public static Stage counter;
    private float bulletTime;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float enemySpeed;
    public float fireRate = 2f;
    public int health = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
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
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30f;
    }
    public void TakeDamage(int amount) {
        currentHealth -= amount;
        if (currentHealth == 0)
        {
            Stage.counter += 1;
            Destroy(gameObject);
        }
    }
}
