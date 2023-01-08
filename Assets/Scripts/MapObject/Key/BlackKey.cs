using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackKey : MonoBehaviour
{
    bool BlueZoneClear = false;

    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();

        if (inventory.ClickedObject.Equals("글루"))
        {
            GameObject BlackKey = GameObject.Find("ActiveFalseObject").transform.Find("회색열쇠").gameObject;
            igloo igloo = GameObject.Find("글루").GetComponent<igloo>();

            if (GameObject.Find("이글루 천장") == null && BlackKey.activeSelf == false && BlueZoneClear == false && igloo.iceClear == true)
            {
                SpriteRenderer spriteRenderer = GameObject.Find("글루").GetComponent<SpriteRenderer>();
                AudioSource KeyDrop = GameObject.Find("KeyDropSound").GetComponent<AudioSource>();

                inventory.UseItem("이글루 천장");
                spriteRenderer.sprite = Resources.Load<Sprite>("이글루") as Sprite;
                BlackKey.SetActive(true);
                KeyDrop.Play();
                BlueZoneClear = true;
            }
        }
    }
}
