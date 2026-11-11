
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody rb;
    private bool isGrounded = false;
 
    public Transform teleportTarget;

    private float horizontal;
    private float vertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        direction = direction.normalized;

        rb.AddForce(direction * moveSpeed);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        isGrounded = false;
        AudioManager.instance.playJumpSound();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Yerdesin!");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenBall"))
        {
            ScoreManager.instance.addScore(10);
            AudioManager.instance.playGreenBallSound();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("RedBall"))
        {
            ScoreManager.instance.removeScore(5);
            AudioManager.instance.playRedBallSound();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Teleporter"))
        {
            transform.position = teleportTarget.transform.position;
            AudioManager.instance.playTeleport();
        }
    }
}