using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    private float TimeLeft = 3.0f;
    private float nextTime = 0.0f;
    bool IsPause;
    public GameObject Pause;
    public GameObject Canvas;
   
    void Start()
    {
        GameObject.Find("Pause").transform.position = new Vector3(-100, -100, 0);
        IsPause = false;
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.Escape))
            {
                /*일시정지 활성화*/
                if (IsPause == false)
                {
                    GameObject.Find("Pause").transform.position = GameObject.Find("Canvas").transform.position;
                    Time.timeScale = 0;
                    IsPause = true;
                    return;
                }

                /*일시정지 비활성화*/
                if (IsPause == true)
                {
                    GameObject.Find("Pause").transform.position = new Vector3(-100, -100, 0);
                    Time.timeScale = 1;
                    IsPause = false;
                    return;
                }

            }
            if (Time.time > nextTime)
            {
                nextTime = Time.time + TimeLeft;
                
            }
    }

}

