using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
	public enum Alphabet {
		A, B, C, D, E, F, G, H, I, J, K, L, M,
		N, O, P, Q, R, S, T, U, V, W, X, Y, Z
	}

	public int framesDelayedBy = 1;
	public AudioClip[] alphabet;

    // Update is called once per frame
    void Update()
    {
        
    }

	public IEnumerator Say(string dialogue) {
		for (int i = 0; i < dialogue.Length; i += framesDelayedBy) {
			yield return null;
		}
	}
}
