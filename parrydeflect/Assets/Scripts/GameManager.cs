using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour { 

	private static int level;
	public static GameObject instance;

	public GameObject[] enemySpawnGroups;
	public enum enemySpawnGroupName {
		Easy, Ok	
	}

	public static int Level {
		get { return level; }
		set { level = value; }
	}

	public GameObject Instance {
		get { return instance; }
	}

	private void Awake() {
		level = 0 ;
		instance = gameObject;
	}

	public static void IncreaseLevel(int n) {
		Level += n;
	}

	public static void ReduceLevel(int n) {
		Level -= n;
	}

	public static void SpawnGroup(GameObject enemies) {
		Object.Instantiate(enemies);
	}
 } 