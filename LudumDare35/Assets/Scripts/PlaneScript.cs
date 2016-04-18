using UnityEngine;
using System.Collections;

public class PlaneScript : MonoBehaviour {
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (player.GetComponent <PlayerMovement>().GetCollided()) {
			transform.GetComponent <MeshRenderer> ().enabled = true;
		}
	}
}
