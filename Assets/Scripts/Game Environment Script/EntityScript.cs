using UnityEngine;

public class EntityScript : MonoBehaviour {
    public int maxHealth;
    public float speed;
    public int damage;

    private Rigidbody2D body;
    protected int health;
    private Transform player;
    private float angle;
    private Vector3 enemyToPlayer;
    private GameObject enemy;
    
    void Start()
    {
        this.health = maxHealth;
        this.body = this.GetComponent<Rigidbody2D>();
        this.player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            this.enemyToPlayer = this.transform.position - this.player.position;
            this.angle = (Mathf.Atan2(this.enemyToPlayer.y, this.enemyToPlayer.x) * Mathf.Rad2Deg) + 270;
            this.transform.rotation = Quaternion.Euler(0, 0, this.angle);

            if (PlayerScript.currentPlayer.playerHealth <= 0)
            {
                PlayerScript.currentPlayer.OnDeath();
                Application.LoadLevel(8);
            }
        }
    }

    void FixedUpdate()
    {
        this.body.velocity = this.transform.up * -this.speed;
    }

	public virtual void ModifyHealth(int amount)
    {
        this.health -= amount;

        if(this.health <= 0)
        {
            this.health = 0;
            this.OnDeath();
        }
        else if(this.health > this.maxHealth)
        {
            this.health = maxHealth;
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerScript.currentPlayer.playerHealth -= damage;
        }
    }

    public virtual void OnDeath()
    {
        Destroy(this.gameObject);
    }
}
