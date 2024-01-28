using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    private readonly float _speed = 8f;
    private float _jumpingPower = 16f;
    private bool _isFacingRight = true;
    public Animator animator;

    [SerializeField] private Rigidbody2D PlayerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Bridge");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("End");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Ducky");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Hell Test");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Frogger2 Test");
        }
        //this is used to get horizontal movement from human
        _horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(_horizontal));
        
        //
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            PlayerBody.velocity = new Vector2(PlayerBody.velocity.x, _jumpingPower);
        }

        if (Input.GetKeyDown(KeyCode.Space) && PlayerBody.velocity.y > 0f)
        {
            PlayerBody.velocity = new Vector2(PlayerBody.velocity.x, PlayerBody.velocity.y * 0.5f);
        }


        Flip();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bean" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Bridge");
        }
        if (collision.tag == "Great" && Input.GetKeyDown(KeyCode.E))
        {

        }
        if (collision.tag == "Buddy" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Ducky");
        }
        if (collision.tag == "Mouth" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Hell Test");
        }
        if (collision.tag == "Frank" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Frogger2 Test");
        }
    }

    private void FixedUpdate()
    {
        PlayerBody.velocity = new Vector2(_horizontal * _speed, PlayerBody.velocity.y);
    }

    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (_isFacingRight && _horizontal < 0f || !_isFacingRight && _horizontal > 0f)
        {
            _isFacingRight = !_isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
