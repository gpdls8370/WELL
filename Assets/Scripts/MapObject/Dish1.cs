using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish1 : MonoBehaviour
{
    
    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();
        Oasis oasis = GameObject.Find("노란지역").GetComponent<Oasis>();

        if (inventory.ClickedObject.Equals("접시1"))
        {
            GameObject banana = GameObject.Find("ActiveFalseObject").transform.Find("용암바위").gameObject;

            if (GameObject.Find("ActiveFalseObject").transform.Find("용암돌") == null && banana.activeSelf == false)
            {
                AudioSource ItemGetSound = GameObject.Find("ItemGetSound").GetComponent<AudioSource>();        //아이템 먹는 사운드 
                ItemGetSound.Play();

                inventory.UseItem("용암돌");
                banana.SetActive(true);
                oasis.Dishclear1 = true;
            }
        }
    }
}
