using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class plateControl : MonoBehaviour
{

    public Transform plateObj;
    public Transform menu1;
    public Transform menu2;

    public GameObject bigPlate;
    public GameObject menu;

    public GameObject carrot;
    public GameObject tomato;
    public GameObject lettuce;
    public GameObject potato;
    public GameObject lobak;

    public GameObject carrot_cook;
    public GameObject lobak_cook;
    public GameObject potato_cook;

    // Start is called before the first frame update
    void Start()
    {
        if(bigPlate == null)
        {
            bigPlate = GameObject.Find("plate2");
        }

        if (menu == null)
        {
            menu = GameObject.Find("menu1");
        }

        if(carrot == null)
        {
            carrot = GameObject.Find("");
        }

        if (carrot_cook == null)
        {
            carrot_cook = GameObject.Find("");
        }

        if (potato== null)
        {
            potato = GameObject.Find("");
        }

        if (tomato == null)
        {
            tomato = GameObject.Find("");
        }

        if (lobak == null)
        {
            lobak = GameObject.Find("");
        }

        if (lettuce == null)
        {
            lettuce = GameObject.Find("");
        }

        if (potato_cook == null)
        {
            potato_cook = GameObject.Find("");
        }

        if (lobak_cook == null)
        {
            lobak_cook = GameObject.Find("");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject.name == "platesmol")
        {
            if (gamePlay.table == "empty")
            {
                Transform menu = Instantiate(menu1, new Vector2(-7.6f, 4.08f), menu1.rotation);
                Transform bigPlate = Instantiate(plateObj, new Vector2(5.34f, -2.16f), plateObj.rotation);
                
                gamePlay.table = "full";
            }

        }
    }

}
