using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKey : MonoBehaviour
{
    bool BlackZoneClear = false;

    void FixedUpdate()
    {
        Volcano volcano = this.GetComponent<Volcano>();

        if (volcano.VolcanoClear == 4 && BlackZoneClear == false)           //화산 4개 다 클리어 하면
        {
            GameObject yellowKey = GameObject.Find("ActiveFalseObject").transform.Find("노랑열쇠").gameObject;
            AudioSource KeyDrop = GameObject.Find("KeyDropSound").GetComponent<AudioSource>();

            yellowKey.SetActive(true);                                                   //열쇠 보이게 설정
            KeyDrop.Play();
            BlackZoneClear = true;
        }
    }
}
