using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ABackButton : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Canvas;
    private void Start()
    {
    }
    public void backScene()
    {
        GameObject.Find("Pause").transform.position = GameObject.Find("Canvas").transform.position;
        Time.timeScale = 0;
    }
}
