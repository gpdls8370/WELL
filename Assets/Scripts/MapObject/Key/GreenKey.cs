using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenKey : MonoBehaviour
{
    bool PinkZoneClear = false;

    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();

        if (inventory.ClickedObject.Equals("분홍나무2"))
        {
            GameObject greenKey = GameObject.Find("ActiveFalseObject").transform.Find("초록열쇠").gameObject;

            if (GameObject.Find("벚꽃") == null && greenKey.activeSelf == false && PinkZoneClear == false)
            {
                SpriteRenderer spriteRenderer = GameObject.Find("분홍나무2").GetComponent<SpriteRenderer>();
                AudioSource KeyDrop = GameObject.Find("KeyDropSound").GetComponent<AudioSource>();

                inventory.UseItem("벚꽃");
                spriteRenderer.sprite = Resources.Load<Sprite>("분홍나무1") as Sprite;
                greenKey.SetActive(true);
                KeyDrop.Play();
                PinkZoneClear = true;
            }
        }
    }
}
