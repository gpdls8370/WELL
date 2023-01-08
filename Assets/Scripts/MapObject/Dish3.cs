using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish3 : MonoBehaviour
{

    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();
        Oasis oasis = GameObject.Find("노란지역").GetComponent<Oasis>();

        if (inventory.ClickedObject.Equals("접시3"))
        {
            GameObject stone = GameObject.Find("ActiveFalseObject").transform.Find("이끼바위").gameObject;

            if (GameObject.Find("ActiveFalseObject").transform.Find("이끼돌") == null && stone.activeSelf == false)
            {
                AudioSource ItemGetSound = GameObject.Find("ItemGetSound").GetComponent<AudioSource>();        //아이템 먹는 사운드 
                ItemGetSound.Play();

                inventory.UseItem("이끼돌");
                stone.SetActive(true);
                oasis.Dishclear3 = true;
            }
        }
    }
}
