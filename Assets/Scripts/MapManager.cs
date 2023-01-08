using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public string colMap = "Main";
    public Vector3 playerPos;

    public bool MainClear = false;
    public bool PinkClear = false;
    public bool GreenClear = false;
    public bool BlueClear = false;
    public bool GrayClear = false;
    public bool YellowClear = false;

    public bool PinkOpen = false;
    public bool GreenOpen = false;
    public bool BlueOpen = false;
    public bool GrayOpen = false;
    public bool YellowOpen = false;


    void Awake()
    {
        playerPos = StaticClass.playerPos;

        if (GameObject.Find("Player").transform.position != playerPos && playerPos != new Vector3(0, 0, 0))
        {
            GameObject.Find("Player").transform.position = playerPos;
        }
    }

    void FixedUpdate()
    {
        if (MainClear == true && PinkOpen == false)            //MainClear가 true이고 PinkOpen이 false이면 -> pink맵을 열어줘야 함
        {
            Destroy(GameObject.Find("p-bridge").gameObject);        //M-PWall을 파괴하고
            PinkOpen = true;                                    //PinkOpen을 true로 바꿔줌
        }

        if (PinkClear == true && GreenOpen == false)
        {
            Destroy(GameObject.Find("green-bridge").gameObject);
            GreenOpen = true;
        }

        if (GreenClear == true && BlueOpen == false)
        {
            Destroy(GameObject.Find("B-bridge").gameObject);
            BlueOpen = true;
        }

        if (BlueClear == true && GrayOpen == false)
        {
            Destroy(GameObject.Find("Gray-bridge").gameObject);
            GrayOpen = true;
        }

        if (GrayClear == true && YellowOpen == false)
        {
            Destroy(GameObject.Find("Gray-YWall").gameObject);
            YellowOpen = true;
        }

        //////////////////////////////////////////////////
        string NowSceneName = SceneManager.GetActiveScene().name;
        

        if (colMap == "Main" && NowSceneName != "MainScene")         //부딪힌맵이 main이고 현재 맵이 main이 아니면
        {
            StaticClass.playerPos = GameObject.Find("Player").transform.position;
            SceneManager.LoadScene("MainScene");
        }

        if (colMap == "Pink" && NowSceneName != "PinkScene")
        {
            StaticClass.playerPos = GameObject.Find("Player").transform.position;
            SceneManager.LoadScene("PinkScene");
        }

        if (colMap == "Green" && NowSceneName != "GreenScene")
        {
            StaticClass.playerPos = GameObject.Find("Player").transform.position;
            SceneManager.LoadScene("GreenScene");
        }

        if (colMap == "Blue" && NowSceneName != "BlueScene")
        {
            StaticClass.playerPos = GameObject.Find("Player").transform.position;
            SceneManager.LoadScene("BlueScene");
        }

        if (colMap == "Gray" && NowSceneName != "GrayScene")
        {
            StaticClass.playerPos = GameObject.Find("Player").transform.position;
            SceneManager.LoadScene("GrayScene");
        }

        if (colMap == "Yellow" && NowSceneName != "YellowScene")
        {
            StaticClass.playerPos = GameObject.Find("Player").transform.position;
            SceneManager.LoadScene("YellowScene");
        }


    }


    


}