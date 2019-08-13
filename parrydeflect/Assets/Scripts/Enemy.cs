using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed;

	public GameObject[] projectile;
	public float projectileSpeed;
	public int shootTimer = 60;
	private int shootCountDown;

	private Vector2 currentPlayerLocation;

    // Start is called before the first frame update
    void Start()
    {
		shootCountDown = shootTimer;
    }

    // Update is called once per frame
    void Update()
    {
		UpdatePlayerLocation();
		ShootCountDown();
    }

	void UpdatePlayerLocation() {
		currentPlayerLocation = PlayerController.currentPosition;
	}

	private void ShootCountDown() {
		shootCountDown--;
		if (shootCountDown < 0) {
			Shoot();
			shootCountDown = shootTimer;
		}
	}

	private void Shoot() {
		GameObject projectileGameObject = Instantiate(this.projectile[0], this.transform.position, Quaternion.identity);

		Projectile projectile = projectileGameObject.GetComponent<Projectile>();
		projectile.speed = projectileSpeed;

		Rigidbody2D rigidbody = projectileGameObject.GetComponent<Rigidbody2D>();

		Vector2 direction = new Vector2(currentPlayerLocation.x - this.transform.position.x, 
			currentPlayerLocation.y - this.transform.position.y);
		rigidbody.velocity = direction.normalized * projectileSpeed;
	}
}
