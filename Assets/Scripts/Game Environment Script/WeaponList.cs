using UnityEngine;

public class WeaponList : MonoBehaviour {
    public WeaponController[] weaponsList;
    private int currentWeapon;

    // Use this for initialization
    void Start () {
        this.currentWeapon = 0;
        this.SwitchWeapons();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("This is the First Weapon");
            this.currentWeapon = 0;
            this.SwitchWeapons();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Debug.Log("This is the Second Weapon");
            this.currentWeapon = 1;
            this.SwitchWeapons();
        }
    }

    void SwitchWeapons()
    {
        for (int i = 0; i < this.weaponsList.Length; i++)
        {
            this.weaponsList[i].gameObject.SetActive(false);
        }
        this.weaponsList[this.currentWeapon].gameObject.SetActive(true);
    }
}
