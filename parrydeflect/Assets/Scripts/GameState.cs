using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState {
	private static GameState instance;

	int points = 0;

	public GameState Instance {
		get { return instance; }	
	}

	//Calling this constructor effectively resets the game state
	public GameState() {
		instance = new GameState();
	}


}
