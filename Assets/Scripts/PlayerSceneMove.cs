using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerSceneMove : MonoBehaviour
{
    Vector3 playerPos;

    void OnTriggerEnter2D(Collider2D col)
    {
        MapManager mapManager = GameObject.Find("MapManager").GetComponent<MapManager>();

        if (col.transform.name=="P LINE"){
            mapManager.colMap = "Pink";
        }

        if (col.transform.name=="Green-line"){
            mapManager.colMap = "Green";
        }

        if (col.gameObject.name=="M-line"){
            mapManager.colMap = "Main";
        }

        if (col.transform.name=="B-line"){
            mapManager.colMap = "Blue";
        }

        if (col.transform.name=="Gray-line"){
            mapManager.colMap = "Gray";
        }

        if (col.transform.name=="Y-line"){
            mapManager.colMap = "Yellow";
        }
    }
}
