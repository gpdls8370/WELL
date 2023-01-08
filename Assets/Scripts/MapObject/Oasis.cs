using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oasis : MonoBehaviour
{
    public bool Dishclear1, Dishclear2, Dishclear3;
    bool Clear = false;

    void FixedUpdate()
    {
        Inventory inventory = Camera.main.GetComponent<Inventory>();

        if (Dishclear1 == true && Dishclear2 == true && Dishclear3 == true && Clear ==false)      
        {
            GameObject oasis = GameObject.Find("ActiveFalseObject").transform.Find("오아시스").gameObject;
            GameObject PlamTree = GameObject.Find("ActiveFalseObject").transform.Find("야자수").gameObject;
            GameObject PlamTreec = GameObject.Find("ActiveFalseObject").transform.Find("야잣수").gameObject;

            AudioSource KeyDrop = GameObject.Find("KeyDropSound").GetComponent<AudioSource>();

            KeyDrop.Play();
            oasis.SetActive(true);
            PlamTree.SetActive(true);
            PlamTreec.SetActive(true);
            Clear = true;
        }

        if (inventory.ClickedObject.Equals("오아시스"))
        {
            Invoke("clear", 1);
        }
    }
    void clear()
    {
        AudioSource BGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        BGM.clip = Resources.Load<AudioClip>("AudioClip/타이틀");
        BGM.Play();
        SceneManager.LoadScene("EndScene");
    }
}
