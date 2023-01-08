using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionReset : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.tag == "wall")

        {

            gameObject.transform.position = new Vector2(680, 606);

        }

    }



}
