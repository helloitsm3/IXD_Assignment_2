using UnityEngine;

public abstract class ProjectileController : MonoBehaviour {
    public float projectileSpeed;
    private float lifetime;

    protected Rigidbody2D rigbody;
    protected WeaponController controller;

    // Use this for initialization
    void Start () {
        this.rigbody = GetComponent<Rigidbody2D>();
        this.rigbody.velocity = this.transform.up * this.projectileSpeed;
        lifetime = 0;
	}

   public void SetWeapon(WeaponController _controller)
    {
        this.controller = _controller;
    }

    void Update()
    {
        lifetime += 0.01f;
        if(lifetime > 1)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        Debug.Log("Bullet Destroyed");
        this.OnCollision(target.gameObject);
        Destroy(this.gameObject);
    }

    protected virtual void OnCollision(GameObject target)
    {
        EntityScript entity = target.GetComponent<EntityScript>();
        
        if(entity != null)
        {
            this.controller.OnHit(entity);
        }
    }
}
