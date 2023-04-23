using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    static public PlayerMovement healthPl;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ye");
            PlayerMovement.healthPl -= 1;
            Destroy(gameObject);
        }
    }
}
