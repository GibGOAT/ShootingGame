using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float xSpeed;
    private float ySpeed;

    public float speed = 3;

    private string InputX = "Horixontal";
    private string InputY = "Vertical";

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        xSpeed = Input.GetAxis("InputX");
        ySpeed = Input.GetAxis("InputY");
        _rigidbody2D.velocity = new Vector2(xSpeed, ySpeed) * speed;
    }

}