using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpHeight;
	public Vector2 vel;
	public Vector2 rbVel;
	public bool jumped;
	private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
		rb = GetComponent<Rigidbody2D>();
		rbVel = rb.velocity;
		vel = new Vector2();

	}

	// Called during physics
	void FixedUpdate() {
		rb.velocity.Set(vel.x, rb.velocity.y);
		Jumped();

	}

	// Update is called once per frame
	void Update() {
		CheckMovement();

	}

	// LateUpdate called after Update
	void LateUpdate() {

	}

	private void CheckMovement() {
		//D up and down
		if (Input.GetKeyDown(KeyCode.D)) {
			AddVel(speed, 0);
		} 
		else if (Input.GetKeyUp(KeyCode.D)) {
			AddVel(-speed, 0);
		}

		//A up and down
		if (Input.GetKeyDown(KeyCode.A)) {
			AddVel(-speed, 0);
		}
		else if (Input.GetKeyUp(KeyCode.A)) {
			AddVel(speed, 0);
		}

		//Space up and down
		if (Input.GetKeyDown(KeyCode.Space)) {
			jumped = true;
		} 
		else if (Input.GetKeyUp(KeyCode.Space)) {

		}

	}

	private void Jumped() {
		if (jumped) {
			jumped = false;
		} 
	}

	private void AddVel(float x, float y) {
		vel.Set(vel.x + x, vel.y + y);
	}

}
