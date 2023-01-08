using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class OnePlayerCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        OneMapManager mapManager = GameObject.Find("MapManager").GetComponent<OneMapManager>();

        if (col.transform.name == "P LINE")
        {
            mapManager.colMap = "Pink";
        }

        if (col.transform.name == "Green-line")
        {
            mapManager.colMap = "Green";
        }

        if (col.gameObject.name == "M-line")
        {
            mapManager.colMap = "Main";
        }

        if (col.transform.name == "B-line")
        {
            mapManager.colMap = "Blue";
        }

        if (col.transform.name == "Gray-line")
        {
            mapManager.colMap = "Gray";
        }

        if (col.transform.name == "Y-line")
        {
            mapManager.colMap = "Yellow";
        }
    }
}
