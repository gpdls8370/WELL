using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleChange: MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(GameObject.Find("SoundManager").gameObject);
        Invoke("load", 4);
    }

    void load()
    {
        SceneManager.LoadScene("GameScene");
    }

}


