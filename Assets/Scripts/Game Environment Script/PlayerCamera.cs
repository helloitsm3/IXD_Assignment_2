using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    private Transform player;
    private float zOffset;
    private Vector3 targetPosition;

    public float timeScale;

    // Use this for initialization
    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player").transform;
        zOffset = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.player != null)
        {
            this.targetPosition = this.player.position + Vector3.back * this.zOffset;
            this.transform.position = Vector3.Lerp(this.transform.position, this.targetPosition, Time.deltaTime * this.timeScale);
        }
    }
}
