using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextLevel1 : MonoBehaviour
{
	public int pickerLv;

	public void hehehe() 
	{
		SceneManager.LoadScene(pickerLv);
	}
}
