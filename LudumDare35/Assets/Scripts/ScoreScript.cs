using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	private int score;
	private GameObject player;

	// Use this for initialization
	void Start () {
		score = 0;
		transform.GetChild (0).GetComponent <Text>().text = "Score: " + score;
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (!player.GetComponent <PlayerMovement>().GetCollided()) {
			score++;
			transform.GetChild (0).GetComponent <Text>().text = "Score: " + score;
		} else {
			transform.GetChild (1).GetComponent <Text>().text = "You Lose!";
			//GameObject.GetComponent <Button> ().enabled = true;
		}
	}
}
