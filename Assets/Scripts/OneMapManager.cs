using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OneMapManager : MonoBehaviour
{
    string NowMapName;
    public string colMap = "Main";

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


    void FixedUpdate()
    {
        SpriteRenderer Pinkbridge = GameObject.Find("핑크다리").GetComponent<SpriteRenderer>();
        SpriteRenderer Greenbridge = GameObject.Find("초록다리").GetComponent<SpriteRenderer>();
        SpriteRenderer Bluebridge = GameObject.Find("파랑다리").GetComponent<SpriteRenderer>();
        SpriteRenderer Graybridge = GameObject.Find("검은다리").GetComponent<SpriteRenderer>();
        SpriteRenderer Yellowbridge = GameObject.Find("노랑다리").GetComponent<SpriteRenderer>();


        if (MainClear == true && PinkOpen == false)            //MainClear가 true이고 PinkOpen이 false이면 -> pink맵을 열어줘야 함
        {
            Destroy(GameObject.Find("p-bridge").gameObject);        //M-PWall을 파괴하고
            Pinkbridge.sprite = Resources.Load<Sprite>("다리") as Sprite;
            GameObject.Find("핑크다리").transform.localScale = new Vector3(3.5f, 8f, 1f);
            PinkOpen = true;                                    //PinkOpen을 true로 바꿔줌
        }

        if (PinkClear == true && GreenOpen == false)
        {
            Destroy(GameObject.Find("green-bridge").gameObject);
            Greenbridge.sprite = Resources.Load<Sprite>("다리") as Sprite;
            GameObject.Find("초록다리").transform.localScale = new Vector3(3.5f, 8f, 1f);
            GreenOpen = true;
        }

        if (GreenClear == true && BlueOpen == false)
        {
            Destroy(GameObject.Find("B-bridge").gameObject);
            Bluebridge.sprite = Resources.Load<Sprite>("다리") as Sprite;
            GameObject.Find("파랑다리").transform.localScale = new Vector3(3.5f, 8f, 1f);
            BlueOpen = true;
        }

        if (BlueClear == true && GrayOpen == false)
        {
            Destroy(GameObject.Find("Gray-bridge").gameObject);
            Graybridge.sprite = Resources.Load<Sprite>("다리") as Sprite;
            GameObject.Find("검은다리").transform.localScale = new Vector3(3.5f, 8f, 1f);
            GrayOpen = true;
        }

        if (GrayClear == true && YellowOpen == false)
        {
            Destroy(GameObject.Find("Y-bridge").gameObject);
            Yellowbridge.sprite = Resources.Load<Sprite>("다리") as Sprite;
            GameObject.Find("노랑다리").transform.localScale = new Vector3(3.5f, 8f, 1f);
            GameObject.Find("ActiveFalseObject").transform.Find("이끼돌").gameObject.SetActive(true);
            GameObject.Find("ActiveFalseObject").transform.Find("용암돌").gameObject.SetActive(true);
            GameObject.Find("ActiveFalseObject").transform.Find("얼음돌").gameObject.SetActive(true);
            YellowOpen = true;
        }

        //////////////////////////////////////////////////
        
        AudioSource BGM = GameObject.Find("BGM").GetComponent<AudioSource>();

        if (colMap == "Pink" && NowMapName != "Pink")
        {
            BGM.clip = Resources.Load<AudioClip>("AudioClip/봄");
            BGM.Play();
            NowMapName = "Pink";
        }

        if (colMap == "Green" && NowMapName != "Green")
        {
            BGM.clip = Resources.Load<AudioClip>("AudioClip/숲");
            BGM.Play();
            NowMapName = "Green";
        }

        if (colMap == "Blue" && NowMapName != "Blue")
        {
            BGM.clip = Resources.Load<AudioClip>("AudioClip/설원");
            BGM.Play();
            NowMapName = "Blue";
        }

        if (colMap == "Gray" && NowMapName != "Gray")
        {
            BGM.clip = Resources.Load<AudioClip>("AudioClip/화산");
            BGM.Play();
            NowMapName = "Gray";
        }

        if (colMap == "Yellow" && NowMapName != "Yellow")
        {
            BGM.clip = Resources.Load<AudioClip>("AudioClip/사막");
            BGM.Play();
            NowMapName = "Yellow";
        }


    }





}