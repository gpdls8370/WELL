using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolharrbang3 : MonoBehaviour
{
    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();
        BlueKey blueKey = GameObject.Find("초록지역").GetComponent<BlueKey>();

        if (inventory.ClickedObject.Equals(this.gameObject.name))
        {
            GameObject mapObject = GameObject.Find("ActiveFalseObject").transform.Find("석상사과3").gameObject;

            if (GameObject.Find("사과3") == null && mapObject.activeSelf == false)    //사과3이 인벤에 있으면
            {
                AudioSource ItemGetSound = GameObject.Find("ItemGetSound").GetComponent<AudioSource>();        //아이템 먹는 사운드 
                ItemGetSound.Play();

                inventory.UseItem("사과3");
                mapObject.SetActive(true);
                blueKey.isApple3 = true;       //초록열쇠 오브젝트의 isApple3을 true로 바꿈
                blueKey.nowAppleOn = "석상3";    //제일 최근에 사과 올린 석상이름 nowAppleOn에 저장
            }
        }
    }
}
