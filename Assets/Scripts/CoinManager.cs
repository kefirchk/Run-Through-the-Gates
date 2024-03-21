using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int NumberOfCoins;
    [SerializeField] private TextMeshProUGUI coinCounter;

    private void Start()
    {
        NumberOfCoins = Progress.Instance.Coins;
        coinCounter.text = NumberOfCoins.ToString();
    }

    public void AddOne()
    {
        ++NumberOfCoins;
        coinCounter.text = NumberOfCoins.ToString();
    }

    public void SaveToProgress()
    {
        Progress.Instance.Coins = NumberOfCoins;
    }

    public void SpendMoney(int value)
    {
        NumberOfCoins -= value;
        coinCounter.text = NumberOfCoins.ToString();
    }
}
