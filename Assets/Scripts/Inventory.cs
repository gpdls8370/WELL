using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public bool isFilledCell1 = false;
    public bool isFilledCell2 = false;
    public bool isFilledCell3 = false;
    public string ClickedObject;
    public string ClickedVolcano;

    int nowCellnum = 0;
    String[] Cellname = new String[4];
    GameObject nowCell;
    GameObject[] Cell = new GameObject[4];
    Image Cellimage;


    public void CellSearch()               //현재 비어있는 셀 정보로 출력
    {
        if (isFilledCell1 == false){
            nowCell = GameObject.Find("Cell1");
            nowCellnum = 1;
        }

        if (isFilledCell1 == true && isFilledCell2 == false){ 
            nowCell = GameObject.Find("Cell2");
            nowCellnum = 2;
        }
        if (isFilledCell1 == true && isFilledCell2 == true && isFilledCell3 == false){
            nowCell = GameObject.Find("Cell3");
            nowCellnum = 3;
        }
        
    }

    void isFilledTrue(int a)
    {
        if (a == 1)
            isFilledCell1 = true;
        if (a == 2)
            isFilledCell2 = true;
        if (a == 3)
            isFilledCell3 = true;
    }

    void isFilledFalse(int a)
    {
        if (a == 1)
            isFilledCell1 = false;
        if (a == 2)
            isFilledCell2 = false;
        if (a == 3)
            isFilledCell3 = false;
    }


    public void GetItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.tag == "DestroyItem")
                {
                    if (isFilledCell1 == false || isFilledCell2 == false || isFilledCell3 == false)
                    {
                        Destroy(hit.collider.gameObject);

                        AudioSource ItemGetSound = GameObject.Find("ItemGetSound").GetComponent<AudioSource>();        //아이템 먹는 사운드 
                        ItemGetSound.Play();

                        CellSearch();
                        Cellimage = nowCell.transform.GetChild(1).GetComponent<Image>();
                        Cellimage.enabled = true;                       //셀 이미지 보이게 하고
                        Cellimage.overrideSprite = Resources.Load<Sprite>(hit.collider.gameObject.name) as Sprite;   //오브젝트랑 이름 같은 sprite 가져옴
                        Cellname[nowCellnum] = hit.collider.gameObject.name;            //Cellname에 얻은 아이템 이름 저장
                        isFilledTrue(nowCellnum);                       //채웠다고 표시
                    }
                }

                if (hit.collider.tag == "RestItem") 
                {
                    ClickedObject = hit.collider.name;
                }

                if (hit.collider.tag == "Volcano")
                {
                    ClickedVolcano = hit.collider.name;
                }
            }
            
        }
    }

    public void UseItem(string name)
    {
        for(int i = 0; i <= 3; i++)
        {
            if (Cellname[i] == name)        //사용하는 아이템이 i번째 셀에 들어있으면
            {
                Cellimage = Cell[i].transform.GetChild(1).GetComponent<Image>();            //i번째 셀의 이미지를 받아옴
                Cellimage.enabled = false;                                                  //i번째 셀을 안보이게 함(아이템 없어짐)
                isFilledFalse(i);                                                           //비어있다고 표시
            }
        }
    }

    private void Start()
    {
        Cell[1] = GameObject.Find("Cell1");
        Cell[2] = GameObject.Find("Cell2");
        Cell[3] = GameObject.Find("Cell3");
    }

    void FixedUpdate()
    {
        if (ClickedObject != "aa" || ClickedVolcano != "aa")
        {
            ClickedObject = "aa";           //ClickedObject 계속 초기화 해주기
            ClickedVolcano = "aa";
        }
        GetItem();
    }
}

