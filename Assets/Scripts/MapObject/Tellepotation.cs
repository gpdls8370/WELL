using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tellepotation : MonoBehaviour
{
    // Start is called before the first frame update
    void tell()
    {
        Invoke("transform.position = new Vector3(2000, 300, 0)", 3);
        Invoke("transform.position = new Vector3(1169, 499, 0)", 3);
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("tell",3,3);
        
        
    }
}
