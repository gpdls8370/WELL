using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : MonoBehaviour
{
    public int VolcanoClear = 0;
 
    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();
        Animator ani1 = GameObject.Find("화산1").GetComponent<Animator>();
        Animator ani2 = GameObject.Find("화산2").GetComponent<Animator>();
        Animator ani3 = GameObject.Find("화산3").GetComponent<Animator>();
        Animator ani4 = GameObject.Find("화산4").GetComponent<Animator>();
        SpriteRenderer sprite1 = GameObject.Find("화산1").GetComponent<SpriteRenderer>();
        SpriteRenderer sprite2 = GameObject.Find("화산2").GetComponent<SpriteRenderer>();
        SpriteRenderer sprite3 = GameObject.Find("화산3").GetComponent<SpriteRenderer>();
        SpriteRenderer sprite4 = GameObject.Find("화산4").GetComponent<SpriteRenderer>();


        //제대로 클릭했을 때
        if (VolcanoClear == 0 && inventory.ClickedVolcano == "화산1")       //화산1 제대로 클릭하면
        {
            ani1.enabled = false;     //화산1 멈춤
            sprite1.sprite = Resources.Load<Sprite>("화산1") as Sprite;
            VolcanoClear++;                 //clear숫자 올림
        }

        else if (VolcanoClear == 1 && inventory.ClickedVolcano == "화산2")
        {
            ani2.enabled = false;
            sprite2.sprite = Resources.Load<Sprite>("화산1") as Sprite;
            VolcanoClear++;
        }

        else if (VolcanoClear == 2 && inventory.ClickedVolcano == "화산3")
        {
            ani3.enabled = false;
            sprite3.sprite = Resources.Load<Sprite>("화산1") as Sprite;
            VolcanoClear++;
        }

        else if (VolcanoClear == 3 && inventory.ClickedVolcano == "화산4")
        {
            ani4.enabled = false;
            sprite4.sprite = Resources.Load<Sprite>("화산1") as Sprite;
            VolcanoClear++;
        }

        else if (inventory.ClickedVolcano == "aa")
            ;


        //제대로 클릭 안 했을 때
        else
        {
            ani1.enabled = true;
            ani2.enabled = true;
            ani3.enabled = true;
            ani4.enabled = true;
            VolcanoClear = 0;
        }
    }
}
