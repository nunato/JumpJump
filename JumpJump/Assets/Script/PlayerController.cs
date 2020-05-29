using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Rigidbody2D rigit2d;
	float jumpForce = 680.0f;
	float walkForce = 30.0f;
	float maxWalkSpeed = 2.0f;

	void Start ()
	{
		this.rigit2d = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
	{
		if( Input.GetKeyDown( KeyCode.Space ) ){
			this.rigit2d.AddForce( transform.up * this.jumpForce );
		}

		int key = 0;
		if( Input.GetKey( KeyCode.RightArrow ) ) key = 1;
		if( Input.GetKey( KeyCode.LeftArrow ) ) key = -1;

		float speeddx = Mathf.Abs( this.rigit2d.velocity.x );

		if( speeddx < maxWalkSpeed ){
			this.rigit2d.AddForce( transform.right * key * this.walkForce );
		}

		if( key != 0 ){
			transform.localScale = new Vector3( key, 1, 1 );
		}
	}
}