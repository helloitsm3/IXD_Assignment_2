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

    public VirtualJoystick moveJoystick, lookJoystick;

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
        if (this.androidInput)
        {
            this.input.Set(moveJoystick.Horizontal(), moveJoystick.Vertical(), 0);

            Quaternion eulerRot = Quaternion.Euler(0.0f, 0.0f, lookJoystick.GetComponentInChildren<VirtualJoystick>().transform.position.x);
            this.transform.rotation = Quaternion.Slerp(transform.rotation, eulerRot, Time.deltaTime * 10);
        }
        else
        {
            this.input.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
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
