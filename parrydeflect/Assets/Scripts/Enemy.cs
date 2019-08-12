using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed;
	public GameObject projectile;
	public float projectileSpeed;

	private Vector2 currentPlayerLocation;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
		UpdatePlayerLocation(); 
    }

	void UpdatePlayerLocation() {
		currentPlayerLocation = PlayerController.currentPosition;
	}
}
