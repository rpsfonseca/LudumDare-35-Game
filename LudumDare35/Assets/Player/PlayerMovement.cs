using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {
	private bool moveDownwards;
	private bool moveUpwards;
	private bool collided = false;
	public float speed = 20;
	public float offset = 60;

	public GameObject cubePlayer;
	public GameObject pyramidPlayer;
	public GameObject cylinderPlayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float yMov = Input.GetAxis ("Horizontal");
		//float xMov = Input.GetAxis ("Vertical");

		if (!collided) {
			transform.Translate (Vector3.right * Time.deltaTime * speed, Space.World);

			if (yMov < 0f && transform.position.z == 0f) {
				moveDownwards = false;
				moveUpwards = true;
			} else if (yMov > 0f && transform.position.z == offset) {
				moveDownwards = true;
				moveUpwards = false;
			}

			if (moveUpwards) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, offset), Time.deltaTime * speed * 3f);
				//transform.Translate (Vector3.forward * Time.deltaTime * 70f, Space.World);// = new Vector3 (transform.position.x, transform.position.y, 40f);//Vector3.Lerp (transform.position, new Vector3 (0f, transform.position.y, transform.position.z), Time.deltaTime * 100f);
			} else if (moveDownwards) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, 0f), Time.deltaTime * speed * 3f);
				//transform.Translate (Vector3.down * Time.deltaTime * 70f, Space.World); //= new Vector3 (transform.position.x, transform.position.y, 0f);//Vector3.Lerp (transform.position, new Vector3 (40f, transform.position.y, transform.position.z), Time.deltaTime * 100f);
			}

			if (transform.position.z >= offset) {
				moveDownwards = false;
			} else if (transform.position.z <= 0f) {
				moveUpwards = false;
			}

		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag.Equals ("Obstacle_Cube") && pyramidPlayer.activeInHierarchy == true) {

			Debug.Log (col);
			collided = true;
			speed = 0f;

		} else if (col.gameObject.tag.Equals ("Obstacle_Pyramid") && cubePlayer.activeInHierarchy == true) {
			Debug.Log (col);
			collided = true;
			speed = 0f;
		}
	}



	/*void FixedUpdate()
	{
		Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		moveDirection = Camera.main.transform.TransformDirection(moveDirection);
		moveDirection.y = 0;


		GetComponent <Rigidbody>().MovePosition(GetComponent <Rigidbody>().position + moveDirection * 20f * Time.deltaTime);
	}*/


}
