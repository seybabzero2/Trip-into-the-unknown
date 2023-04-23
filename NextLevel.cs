using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int sceneName;
    public static Stage counter;

    private void OnMouseDown()
    {
        Stage.counter = 0;
        SceneManager.LoadScene(sceneName);
    }
}
