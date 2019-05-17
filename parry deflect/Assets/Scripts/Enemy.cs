using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject proj;
	public GameObject target;
	public float pVel;
	public float projSpeed;
	public int shootTimer;
	public int shootTimerStart;
	public Vector2 shootDirection;

    // Start is called before the first frame update
    void Start() {
		shootTimer = 1;
	}

    // Update is called once per frame
    void Update() {
		shootTimer--;
		if (shootTimer == 0) {
			FindPlayer();
			ShootAtPlayer();
			shootTimer = shootTimerStart;
		}
    }

	private void FindPlayer() {
		Vector2 t = target.GetComponent<Transform>().position;
		Vector2 e = this.GetComponent<Transform>().position;

		float x = t.x - e.x;
		float y = t.y - e.y;
		shootDirection.Set(x, y);
		float d = shootDirection.magnitude;

		shootDirection.Set(x / d, y / d);
	}

	private void ShootAtPlayer() {
		Vector2 thisPos = this.GetComponent<Transform>().position;
		proj.transform.position = thisPos;
		proj.GetComponent<Rigidbody2D>().velocity = new Vector2(shootDirection.x * projSpeed, shootDirection.y * projSpeed);
	}
}
