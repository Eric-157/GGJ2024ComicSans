using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

public class Car : MonoBehaviour
{

	public Rigidbody2D rb;

	public float minSpeed = 8f;
	public float maxSpeed = 12f;

	float speed = 1f;
	public float by;
	

	void Start()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate()
	{
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * (Time.fixedDeltaTime * speed));

		by = transform.position.y;


		
		
	}

	private void KillBullet()
	{
		
		Destroy(this);
		Debug.Log("destroyed bullet");
		
	}

	private void OnCollisionExit2D(Collision2D collision2D)
	{
		KillBullet();
	}
}
