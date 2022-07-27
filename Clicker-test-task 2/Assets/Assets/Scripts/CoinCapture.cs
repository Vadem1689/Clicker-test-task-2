using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCapture : MonoBehaviour
{
    public int coins;
    public Text TextCoin;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
            TextCoin.text = coins.ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Money")
        {
            coins += 10;
            other.gameObject.SetActive(false);
            TextCoin.text = coins.ToString();

            PlayerPrefs.SetInt("Coins", coins);
        }
    }
}
