using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class coinCounter : MonoBehaviour
{
    public static coinCounter instance;

    public TextMeshProUGUI coin;
    public int currentCoin = 0;

    private void Awake()
    {
        instance = this;        
    }
    // Start is called before the first frame update
    void Start()
    {
        coin.text = currentCoin.ToString();
    }

    public void IncreaseCoins(int v)
    {
        currentCoin += v;
        coin.text = currentCoin.ToString();
    }
}
