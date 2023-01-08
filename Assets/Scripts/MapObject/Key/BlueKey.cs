using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKey : MonoBehaviour
{
    public bool isApple1, isApple2, isApple3;
    public string nowAppleOn;
    bool GreenZoneClear = false;

    void FixedUpdate()
    {
        if (isApple1 == true && isApple2 == true && isApple3 == true && GreenZoneClear == false)           //석상에 사과 3개 다 올리면
        {
            GameObject nowDolharrbang = GameObject.Find(nowAppleOn);
            GameObject blueKey = GameObject.Find("ActiveFalseObject").transform.Find("파랑열쇠").gameObject;
            AudioSource KeyDrop = GameObject.Find("KeyDropSound").GetComponent<AudioSource>();

            blueKey.SetActive(true);                                                   //열쇠 보이게 설정
            KeyDrop.Play();
            blueKey.transform.position = nowDolharrbang.transform.position;            //파랑열쇠 위치 현재 석상으로 옮김
            GreenZoneClear = true;
        }
    }
}
