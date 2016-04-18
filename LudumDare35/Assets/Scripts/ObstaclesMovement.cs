using UnityEngine;
using System.Collections;

public class ObstaclesMovement : MonoBehaviour {
	public float speed = 20;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (!player.GetComponent <PlayerMovement>().GetCollided()) {
			transform.Translate (Vector3.right * Time.deltaTime * speed, Space.World);
		}
		if (transform.position.x - player.transform.position.x < -70) {
			Destroy (gameObject);
		}
	}
}
