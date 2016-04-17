using UnityEngine;
using System.Collections;

public class FadeOutObject : MonoBehaviour {
	public GameObject player;
	private float dist;
	private Color objColor;

	void Start() {
		//objColor = GetComponentInChildren <MeshRenderer> ().material.color;
		//Debug.Log (objColor);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - player.transform.position.x < -70) {
			Destroy (gameObject);
		}
	}
}
