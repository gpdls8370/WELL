using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWell : MonoBehaviour
{
    Inventory inventory;
    OneMapManager oneMapManager;
    SpriteRenderer spriteRenderer;

    void FixedUpdate()
    {
        inventory = Camera.main.GetComponent<Inventory>();                      //Inventory스크립트 불러오기
        oneMapManager = GameObject.Find("MapManager").GetComponent<OneMapManager>();
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

        if (inventory.ClickedObject.Equals(this.gameObject.name))           //이 오브젝트가 클릭되면 상호작용
        {
            AudioSource WellClearSound = GameObject.Find("WellClearSound").GetComponent<AudioSource>();

            if (GameObject.Find("핑크열쇠") == null && oneMapManager.MainClear == false)          //핑크열쇠 인벤에 있고 MainClear가 false이면
            {
                inventory.UseItem("핑크열쇠");                                              //핑크열쇠 사용하고  
                oneMapManager.MainClear = true;                                                //MainClear true로 바꾸고
                WellClearSound.Play();
                spriteRenderer.sprite = Resources.Load<Sprite>("우물/핑크우물") as Sprite;             //우물 sprite 핑크로 바꿈
            }

            if (GameObject.Find("ActiveFalseObject").transform.Find("초록열쇠") == null && oneMapManager.PinkClear == false)
            {
                inventory.UseItem("초록열쇠");
                oneMapManager.PinkClear = true;
                WellClearSound.Play();
                spriteRenderer.sprite = Resources.Load<Sprite>("우물/초록우물") as Sprite;
            }

            if (GameObject.Find("ActiveFalseObject").transform.Find("파랑열쇠") == null && oneMapManager.GreenClear == false)
            {
                inventory.UseItem("파랑열쇠");
                oneMapManager.GreenClear = true;
                WellClearSound.Play();
                spriteRenderer.sprite = Resources.Load<Sprite>("우물/파랑우물") as Sprite;
            }

            if (GameObject.Find("ActiveFalseObject").transform.Find("회색열쇠") == null && oneMapManager.BlueClear == false)
            {
                inventory.UseItem("회색열쇠");
                oneMapManager.BlueClear = true;
                WellClearSound.Play();
                spriteRenderer.sprite = Resources.Load<Sprite>("우물/회색우물") as Sprite;
            }

            if (GameObject.Find("ActiveFalseObject").transform.Find("노랑열쇠") == null && oneMapManager.GrayClear == false)
            {
                inventory.UseItem("노랑열쇠");
                oneMapManager.GrayClear = true;
                WellClearSound.Play();
                spriteRenderer.sprite = Resources.Load<Sprite>("우물/노랑우물") as Sprite;
            }
        }
    }
}
