using UnityEngine;
using System.Collections;

public class PlaySoundOnBump : MonoBehaviour {
	void OnCollisionEnter(Collision c) {
		GetComponent<AudioSource>().Play();
	}
}
