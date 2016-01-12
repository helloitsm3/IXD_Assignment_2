using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public bool androidInput;
    public int playerSpeed;
    public int playerHealth;
    public static PlayerScript currentPlayer;

    private Rigidbody2D rigbody;
    private Vector3 input;
    private Camera playerCamera;
    private Vector2 playerToMouse;
    private float playerAngle;

    void Awake()
    {
        currentPlayer = this;
    }

	// Use this for initialization
	void Start () {
        this.rigbody = GetComponent<Rigidbody2D>();
        this.input = Vector3.zero;
        this.playerCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        this.input.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        if (this.androidInput)
        {
            if (this.input != Vector3.zero)
            {
                if (this.input.y != 0)
                {
                    if (this.input.y > 0)
                    {
                        this.transform.rotation = Quaternion.identity;
                    }
                    else if (this.input.y < 0)
                    {
                        this.transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                }

                else if (this.input.x != 0)
                {
                    if (this.input.x > 0)
                    {
                        this.transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (this.input.x < 0)
                    {
                        this.transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
            }
        }
        else
        {
            this.playerToMouse = this.transform.position - this.playerCamera.ScreenToWorldPoint(Input.mousePosition);
            this.playerAngle = (Mathf.Atan2(this.playerToMouse.x, this.playerToMouse.y) * -Mathf.Rad2Deg) + 180;
            this.transform.rotation = Quaternion.Euler(0, 0, this.playerAngle);
        }

        if (Input.GetKey("backspace"))
            Application.LoadLevel(5);

        UIController.current.PlayerHealthBar(playerHealth);
	}

    public void OnDeath()
    {
        Destroy(this.gameObject);
    }

    void FixedUpdate()
    {
        this.rigbody.velocity = this.input * this.playerSpeed;
    }
}
