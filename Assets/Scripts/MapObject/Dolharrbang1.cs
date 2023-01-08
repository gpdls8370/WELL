using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolharrbang1 : MonoBehaviour
{
    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();
        BlueKey blueKey = GameObject.Find("초록지역").GetComponent<BlueKey>();

        if (inventory.ClickedObject.Equals(this.gameObject.name))
        {
            GameObject mapObject = GameObject.Find("ActiveFalseObject").transform.Find("석상사과1").gameObject;

            if (GameObject.Find("사과1") == null && mapObject.activeSelf == false)    //사과1이 인벤에 있으면(프로젝트에서 파괴됐으면)
            {
                AudioSource ItemGetSound = GameObject.Find("ItemGetSound").GetComponent<AudioSource>();        //아이템 먹는 사운드 
                ItemGetSound.Play();

                inventory.UseItem("사과1");
                mapObject.SetActive(true);
                blueKey.isApple1 = true;       //초록열쇠 오브젝트의 isApple1을 true로 바꿈
                blueKey.nowAppleOn = "석상1";    //제일 최근에 사과 올린 석상이름 nowAppleOn에 저장
            }
        }
    }
}
