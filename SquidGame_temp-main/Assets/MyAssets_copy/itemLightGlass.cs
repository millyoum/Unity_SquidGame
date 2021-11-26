using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemLightGlass : MonoBehaviour
{
    public GameObject player;
    public Material unbreakable;
    public Material window;
    public GameObject flash_item;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        window = Resources.Load("Window", typeof(Material)) as Material;
        unbreakable = Resources.Load("Unbreakable glass", typeof(Material)) as Material;
        GetComponent<Renderer>().material = window;
        //손전등 아이템과 동기화 위해 오브젝트 생성
        flash_item = GameObject.FindGameObjectWithTag("light"); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && flash_item.GetComponent<Light>().enabled == true)
        {
            GetComponent<Renderer>().material = unbreakable;
            Debug.Log("바닥 색깔 체크");

            //손전등 변수 light num
            /*if (flash_item.GetComponent<itemFlashLight>().light_num > 0 &&
                flash_item.GetComponent<itemFlashLight>().light_num <= 3)
            {
                GetComponent<Renderer>().material = unbreakable;
                Debug.Log("바닥 색깔 체크");
            }*/
        }

        else if (flash_item.GetComponent<Light>().enabled == false)
        {
            GetComponent<Renderer>().material = window;
        }
    }
}
