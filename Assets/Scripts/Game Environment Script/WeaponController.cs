using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {
    public Sprite weaponIcon;
    public Transform Spawner;
    public GameObject projectilePrfb;
    public int maxAmmunition;

    protected int currentAmmunition;
    protected int damage;
    protected float time;
    protected float coolDownTime;

    void OnEnable()
    {
        if(UIController.current != null)
        {
            UIController.current.weaponIcon.sprite = this.weaponIcon;
            UIController.current.weaponAmmo.text = this.currentAmmunition + " / " + this.maxAmmunition;
        }        
    }

	// Update is called once per frame
	void Update () {
        // For Ammo Management and Firing
	    if(this.time < this.coolDownTime)
        {
            this.time += Time.deltaTime;
        }
        else if(Input.GetButton("Fire1"))
        {
            this.time = 0;
            
            if(this.currentAmmunition > 0)
            {
                this.Shoot();
                this.currentAmmunition--;
            }
            else if(this.currentAmmunition <= 0)
            {
                this.currentAmmunition = maxAmmunition;
            }
        }

        UIController.current.weaponAmmo.text = this.currentAmmunition + " / " + this.maxAmmunition;
    }

    public virtual void OnHit(EntityScript obj)
    {
        obj.ModifyHealth(this.damage);
    }

    protected virtual void Shoot()
    {
        GameObject projectile = Instantiate(this.projectilePrfb, this.Spawner.position, this.Spawner.rotation) as GameObject;
        projectile.GetComponent<ProjectileController>().SetWeapon(this);
    }
}
