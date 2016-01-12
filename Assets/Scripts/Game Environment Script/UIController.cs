using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public static UIController current;

    public Slider playerHealthbar;
    public Text weaponAmmo;
    public Image weaponIcon;

	void Awake()
    {
        current = this;
    }

    public void PlayerHealthBar(int health)
    {
        playerHealthbar.value = health;
    }
}
