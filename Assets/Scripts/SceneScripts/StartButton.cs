using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void Start()
    {
        
    }
    public void Startgame()
    {
        SceneManager.LoadScene("MainScene");
    }
    // Update is called once per frame
 
}
