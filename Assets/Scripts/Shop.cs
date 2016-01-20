using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shop : MonoBehaviour {
    public Text weaponText;
    public Button weaponButton;

    public void WeaponBought()
    {
        Debug.Log(weaponText + "Bought when " + weaponButton + " is click");
    }
}
