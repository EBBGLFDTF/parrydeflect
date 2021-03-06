﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	Rigidbody2D rigidbody;
	public static Vector2 currentPosition;

	//movement
	public float speed = 1.0f;

	private void Awake() {
	}

	// Start is called before the first frame update
	void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
		Move();
		UpdatePosition();
    }

	private void Move() {
		float xMovement = Input.GetAxisRaw("Horizontal");
		float yMovement = Input.GetAxisRaw("Vertical");

		Vector2 direction = new Vector2(xMovement, yMovement);
		direction = direction.normalized;
		
		Vector2 newPosition = rigidbody.position + (direction * this.speed);
		rigidbody.MovePosition(newPosition);
	}

	private void UpdatePosition() {
		currentPosition = this.transform.position;	
	}

}
