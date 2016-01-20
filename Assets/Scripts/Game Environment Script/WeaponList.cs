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
	void Update () {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            this.currentWeapon = 0;
            this.SwitchWeapons();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            this.currentWeapon = 1;
            this.SwitchWeapons();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            this.currentWeapon = 2;
            this.SwitchWeapons();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            this.currentWeapon = 3;
            this.SwitchWeapons();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            this.currentWeapon = 4;
            this.SwitchWeapons();
        }
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
