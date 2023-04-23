using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BulletScript : MonoBehaviour
{
    public static EnemyFollowing health;
    public static Boss health1;

    public float life = 3;
    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            print("11");
            Debug.Log("11");
            other.gameObject.GetComponent<EnemyFollowing>().TakeDamage(1);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "BOSS")
        {   
            print("11");
            Debug.Log("11");
            other.gameObject.GetComponent<Boss>().TakeDamage(1);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Finish")
        {
            print("11");
            Debug.Log("11");
            SceneManager.LoadScene(0);
        }
    }

}
