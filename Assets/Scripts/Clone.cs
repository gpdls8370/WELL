using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cha;
    public void Cre()
    {
        Instantiate(cha, new Vector3(0,0,0), Quaternion.identity);
        Destroy(cha);
    }
}
