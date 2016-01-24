using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponSwitchingScript : MonoBehaviour
{
    public Image[] WeaponnSlot;
    public Button leftArrow, rightArrow;
    public static WeaponSwitchingScript currentSlot;
    public int currentEquipWeapon;

    void Awake()
    {
        currentSlot = this;
    }

    void Start()
    {
        this.currentEquipWeapon = 0;
        this.SwitchWeapon();

        leftArrow = GetComponent<Button>();
        rightArrow = GetComponent<Button>();
    }

    public void PreviousWeapon()
    {
        currentEquipWeapon--;
        if(currentEquipWeapon <= 0)
        {
            currentEquipWeapon = 0;
        }

        this.SwitchWeapon();
    }

    public void NextWeapon()
    {
        currentEquipWeapon++;
        if (currentEquipWeapon >= WeaponnSlot.Length)
        {
            currentEquipWeapon = WeaponnSlot.Length - 1;
        }

        this.SwitchWeapon();
    }

    void SwitchWeapon()
    {
        for (int i = 0; i < this.WeaponnSlot.Length; i++)
        {
            this.WeaponnSlot[i].gameObject.SetActive(false);
        }
        this.WeaponnSlot[this.currentEquipWeapon].gameObject.SetActive(true);
    }
}
