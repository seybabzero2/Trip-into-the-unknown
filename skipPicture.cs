using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipPicture : MonoBehaviour
{
	public void Button() 
	{
		Destroy(gameObject);
	}
	public void Start()
	{
		Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
	}
}
