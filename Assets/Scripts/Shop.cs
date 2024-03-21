using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;

    private PlayerModifier playerModifier;

    private void Start()
    {
        playerModifier = FindObjectOfType<PlayerModifier>();
    }

    public void BuyWidth()
    {
        if(coinManager.NumberOfCoins >= 25)
        {
            coinManager.SpendMoney(25);
            Progress.Instance.Coins = coinManager.NumberOfCoins;
            Progress.Instance.Width += 25;
            playerModifier.SetWidth(Progress.Instance.Width);
        }
    }

    public void BuyHeight() 
    {
        if (coinManager.NumberOfCoins >= 25)
        {
            coinManager.SpendMoney(25);
            Progress.Instance.Coins = coinManager.NumberOfCoins;
            Progress.Instance.Height += 25;
            playerModifier.SetHeight(Progress.Instance.Height);
        }
    }
}
