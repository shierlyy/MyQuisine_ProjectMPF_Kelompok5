using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class SubmitPlate : MonoBehaviour
{
    public int value = 5;
    public void OnSubmitButtonClick()
    {
        GameObject[] bigPlates = GameObject.FindGameObjectsWithTag("BigPlateClone");
        foreach (GameObject bigPlate in bigPlates)
        {
            Destroy(bigPlate);
            gamePlay.table = "empty";
            coinCounter.instance.IncreaseCoins(value);
        }

        GameObject[] menus = GameObject.FindGameObjectsWithTag("MenuClone");
        foreach (GameObject menu in menus)
        {
            Destroy(menu);
        }

        GameObject[] carrots = GameObject.FindGameObjectsWithTag("CarrotClone");
        foreach (GameObject carrot in carrots)
        {
            Destroy(carrot);
        }

        GameObject[] carrot_cooks = GameObject.FindGameObjectsWithTag("CarrotCookClone");
        foreach (GameObject carrot_cook in carrot_cooks)
        {
            Destroy(carrot_cook);
        }

        GameObject[] potatos = GameObject.FindGameObjectsWithTag("PotatoClone");
        foreach (GameObject potato in potatos)
        {
            Destroy(potato);
        }

        GameObject[] potato_cooks = GameObject.FindGameObjectsWithTag("PotatoCookClone");
        foreach (GameObject potato_cook in potato_cooks)
        {
            Destroy(potato_cook);
        }

        GameObject[] lobaks = GameObject.FindGameObjectsWithTag("LobakClone");
        foreach (GameObject lobak in lobaks)
        {
            Destroy(lobak);
        }

        GameObject[] lobak_cooks = GameObject.FindGameObjectsWithTag("LobakCookClone");
        foreach (GameObject lobak_cook in lobak_cooks)
        {
            Destroy(lobak_cook);
        }

        GameObject[] tomatos = GameObject.FindGameObjectsWithTag("TomatoClone");
        foreach (GameObject tomato in tomatos)
        {
            Destroy(tomato);
        }

        GameObject[] lettuces = GameObject.FindGameObjectsWithTag("LettuceClone");
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(lettuce);
        }

    }

}
