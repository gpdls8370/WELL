using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish2 : MonoBehaviour
{

    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();
        Oasis oasis = GameObject.Find("노란지역").GetComponent<Oasis>();

        if (inventory.ClickedObject.Equals("접시2"))
        {
            GameObject ice = GameObject.Find("ActiveFalseObject").transform.Find("얼음바위").gameObject;

            if (GameObject.Find("ActiveFalseObject").transform.Find("얼음돌") == null && ice.activeSelf == false)
            {
                AudioSource ItemGetSound = GameObject.Find("ItemGetSound").GetComponent<AudioSource>();        //아이템 먹는 사운드 
                ItemGetSound.Play();

                inventory.UseItem("얼음돌");
                ice.SetActive(true);
                oasis.Dishclear2 = true;
            }
        }
    }
}
