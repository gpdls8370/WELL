using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class igloo : MonoBehaviour
{
    bool BlueZoneClear = false;
    public bool iceClear = false;

    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();

        if (inventory.ClickedObject.Equals("글루"))
        {
            GameObject BlackKey = GameObject.Find("ActiveFalseObject").transform.Find("회색열쇠").gameObject;

            if (GameObject.Find("얼음") == null && BlackKey.activeSelf == false && BlueZoneClear == false)
            {
                SpriteRenderer spriteRenderer = GameObject.Find("글루").GetComponent<SpriteRenderer>();
                
                inventory.UseItem("얼음");
                spriteRenderer.sprite = Resources.Load<Sprite>("2글루") as Sprite;
                iceClear = true;
            }
        }
    }
}
