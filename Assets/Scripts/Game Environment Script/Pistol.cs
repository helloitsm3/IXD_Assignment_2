using System;
using UnityEngine;
public class Pistol : WeaponController {
	// Use this for initialization
	void Start () {
        this.currentAmmunition = this.maxAmmunition;

        this.coolDownTime = 0.2f;
        this.time = this.coolDownTime;
        this.damage = 10;

        UIController.current.weaponIcon.sprite = this.weaponIcon;
        UIController.current.weaponAmmo.text = this.currentAmmunition + " / " + this.maxAmmunition;
    }
}
