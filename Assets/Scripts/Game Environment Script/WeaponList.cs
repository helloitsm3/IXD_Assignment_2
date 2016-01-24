using UnityEngine;

public class WeaponList : MonoBehaviour {
    public WeaponController[] weaponsList;
    private int currentWeapon;
    ProjectileController projectiles;

    // Use this for initialization
    void Start () {
        this.currentWeapon = 0;
        this.SwitchWeapons();

        projectiles = GetComponent<ProjectileController>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        currentWeapon = WeaponSwitchingScript.currentSlot.currentEquipWeapon;
        SwitchWeapons();
    }

    public void SwitchWeapons()
    {
        for (int i = 0; i < this.weaponsList.Length; i++)
        {
            this.weaponsList[i].gameObject.SetActive(false);
        }
        this.weaponsList[this.currentWeapon].gameObject.SetActive(true);
    }
}
