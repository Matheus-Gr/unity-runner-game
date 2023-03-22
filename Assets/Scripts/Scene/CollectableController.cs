using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    public static int coinCount;
    public TMP_Text CoinText;

    public static int sessionCoinCount = 0;
    private void Start()
    {
        coinCount = PlayerPrefs.GetInt("CoinCount", 0);
    }

    void Update()
    {
        CoinText.text = "" + sessionCoinCount;
    }

    public static void CoinUpdate(int quantity)
    {
        sessionCoinCount += quantity;
        coinCount += quantity;
        PlayerPrefs.SetInt("CoinCount", coinCount);
        PlayerPrefs.Save();
    }
}
