using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointSystemScript : MonoBehaviour {
    public Text playerScoreText;

    void Update()
    {
        playerScoreText.text = Shop.currentShop.playerScorePoints.ToString() + " Points";
    }
}
