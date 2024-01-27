using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    private readonly float _speed = 8f;
    private float _jumpingPower = 16f;
    private bool _isFacingRight = true;

    [SerializeField] private Rigidbody2D PlayerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        //this is used to get horizontal movement from human
        _horizontal = Input.GetAxisRaw("Horizontal");

        
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
