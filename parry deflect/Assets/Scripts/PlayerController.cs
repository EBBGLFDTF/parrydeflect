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
		rbVel = new Vector2();
		vel = new Vector2();

	}

	// Called during physics
	void FixedUpdate() {
		rb.velocity = vel;
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

		//W up and down
		if (Input.GetKeyDown(KeyCode.W)) {
			AddVel(0, speed);
		} else if (Input.GetKeyUp(KeyCode.W)) {
			AddVel(0, -speed);
		}

		//S up and down
		if (Input.GetKeyDown(KeyCode.S)) {
			AddVel(0, -speed);
		} else if (Input.GetKeyUp(KeyCode.S)) {
			AddVel(0, speed);
		}

		//Space up and down
		if (Input.GetKeyDown(KeyCode.Space)) {
			jumped = true;
		} 
		else if (Input.GetKeyUp(KeyCode.Space)) {

		}

	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (Input.GetKey(KeyCode.Space)) {
			Debug.Log("HIT");
			GameObject proj = collision.gameObject;
			Vector2 projVel = proj.GetComponent<Rigidbody2D>().velocity;
			proj.GetComponent<Rigidbody2D>().velocity = new Vector2(-projVel.x, -projVel.y);
		}
	}

	private void Deflect() {

	}

	private void AddVel(float x, float y) {
		vel.Set(vel.x + x, vel.y + y);
	}

}
