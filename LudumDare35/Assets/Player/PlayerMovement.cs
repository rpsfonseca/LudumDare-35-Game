using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class PlayerMovement : MonoBehaviour {
	private bool moveRight;
	private bool moveRightRight;
	private bool moveLeft;
	private bool moveLeftLeft;
	private bool collided = false;
	public float speed = 20;
	public float offset = 60;
	//private float lastKeyPressed;

	public GameObject cubePlayer;
	public GameObject pyramidPlayer;
	public GameObject cylinderPlayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown ("left")) {
			Debug.Log ("PRESSSSS");
		}*/

		//lastKeyPressed = yMov;

		/*Debug.Log (yMov);
		Debug.Log (moveLeft);
		Debug.Log (moveLeftLeft);
		Debug.Log (moveRight);
		Debug.Log (moveRightRight);*/

		if (!collided) {
			transform.Translate (Vector3.right * Time.deltaTime * speed, Space.World);

			if (/*yMov < 0f*/Input.GetKeyDown ("left") && transform.position.z == 0f) {
				moveRight = false;
				moveRightRight = false;
				moveLeft = true;
				moveLeftLeft = false;
			} else if (/*yMov < 0f*/ Input.GetKeyDown ("left") && transform.position.z == -offset) {
				moveRight = false;
				moveRightRight = false;
				moveLeft = false;
				moveLeftLeft = true;
			} else if (/*yMov > 0f*/Input.GetKeyDown ("right") && transform.position.z == offset) {
				moveRight = true;
				moveRightRight = false;
				moveLeft = false;
				moveLeftLeft = false;
			} else if (/*yMov > 0f*/Input.GetKeyDown ("right") && transform.position.z == 0f) {
				moveRight = false;
				moveRightRight = true;
				moveLeft = false;
				moveLeftLeft = false;
			} /*else {
				moveRight = false;
				moveRightRight = false;
				moveLeft = false;
				moveLeftLeft = false;
			}*/

			if (moveLeft && !moveLeftLeft && !moveRight && !moveRightRight) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, offset), Time.deltaTime * speed * 3f);
			} else if ((moveRight || moveLeftLeft) && !moveRightRight && !moveLeft) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, 0f), Time.deltaTime * speed * 3f);
			} else if (moveRightRight && !moveLeftLeft && !moveRight && !moveLeft) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, -offset), Time.deltaTime * speed * 3f);
			}

			/*if (transform.position.z >= offset) {
				moveRight = false;
			} else if (transform.position.z < 0f) {
				moveLeft = false;
			} else if (transform.position.z <= -offset) {
				moveRightRight = false;
			} */
				
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag.Equals ("Obstacle_Cube") && (pyramidPlayer.activeInHierarchy == true  || cylinderPlayer.activeInHierarchy == true)) {
			//Debug.Log (col);
			collided = true;
			speed = 0f;
		} else if (col.gameObject.tag.Equals ("Obstacle_Pyramid") && (cubePlayer.activeInHierarchy == true || cylinderPlayer.activeInHierarchy == true)) {
			//Debug.Log (col);
			collided = true;
			speed = 0f;
		} else if (col.gameObject.tag.Equals ("Obstacle_Cylinder") && (cubePlayer.activeInHierarchy == true || pyramidPlayer.activeInHierarchy == true)) {
			//Debug.Log (col);
			collided = true;
			speed = 0f;
		}
	}
}
