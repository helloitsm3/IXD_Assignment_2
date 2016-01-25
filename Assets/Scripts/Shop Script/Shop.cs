using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shop : MonoBehaviour {
    public Button[] weaponButton;
    public Text playerScoreText;
    public static Shop currentShop;
    public int playerScorePoints;

    void Awake()
    {
        currentShop = this;
    }

    public void buyAssaultRifle(int price)
    {
        this.playerScorePoints -= price;
    }

    public void buyPistol(int price)
    {
        this.playerScorePoints -= price;
    }

    public void buyPotion(int price)
    {
        this.playerScorePoints -= price;
    }

    void Update()
    {
        Debug.Log(this.playerScorePoints);
    }
}
