using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    public static int counter = 0;
    public GameObject paticle;
    public GameObject perexod;
    public int maxCounter = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == maxCounter)
        {
            Instantiate(paticle, gameObject.transform.position, gameObject.transform.rotation);
            Instantiate(perexod, gameObject.transform.position, gameObject.transform.rotation);
            counter = maxCounter++;
        }
    }
}
