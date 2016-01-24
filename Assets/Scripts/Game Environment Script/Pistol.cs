using System;
using UnityEngine;
public class Pistol : WeaponController {
	// Use this for initialization
	void Start () {
        this.currentAmmunition = this.maxAmmunition;
        
        this.time = this.coolDownTime;

        //UIController.current.weaponIcon.sprite = this.weaponIcon;
        UIController.current.weaponAmmo.text = this.currentAmmunition + " / " + this.maxAmmunition;
    }
}
