using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceLabel : MonoBehaviour
{
    public TMP_Text CostCount;
    public TMP_Text ActualCount;

    public static int ActualCost = 100;

    private void Start()
    {
        ActualCost = PlayerPrefs.GetInt("ActualPrice", 100);
        CollectableController.coinCount = PlayerPrefs.GetInt("CoinCount", 0);
    }

    void Update()
    {
        ActualCount.text = "" + CollectableController.coinCount;
        CostCount.text = "" + ActualCost;
    }

}
