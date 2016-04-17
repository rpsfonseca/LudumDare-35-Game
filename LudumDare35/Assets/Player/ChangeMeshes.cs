using UnityEngine;
using System.Collections;

public class ChangeMeshes : MonoBehaviour {

	public GameObject cubePlayer;
	public GameObject pyramidPlayer;
	public GameObject cylinderPlayer;

	/*Mesh initialMesh;
	Mesh swapMesh;*/

	//GameObject theTarget;

	// Use this for initialization
	void Update () {
		if (Input.GetKeyDown ("1") && cubePlayer.activeInHierarchy == false) {
			//onePressed++;

			if (pyramidPlayer.activeInHierarchy == true) {
				cubePlayer.SetActive (true);
				pyramidPlayer.SetActive (false);
			} else if (cylinderPlayer.activeInHierarchy == true) {
				cubePlayer.SetActive (true);
				cylinderPlayer.SetActive (false);
			}
			//theTarget = initialObject;


			/*initialMesh = initialObject.GetComponent<MeshFilter> ().mesh;
			swapMesh = swapObject.GetComponent<MeshFilter> ().sharedMesh;

			theTarget.GetComponent<MeshFilter> ().mesh = swapMesh;*/

			//theTarget.GetComponent <GameObject> () = swapObject.GetComponent<GameObject> ();
		} else if (Input.GetKeyDown ("2") && pyramidPlayer.activeInHierarchy == false) {
			if (cubePlayer.activeInHierarchy == true) {
				cubePlayer.SetActive (false);
				pyramidPlayer.SetActive (true);
			} else if (cylinderPlayer.activeInHierarchy == true) {
				pyramidPlayer.SetActive (true);
				cylinderPlayer.SetActive (false);
			}
		} else if (Input.GetKeyDown ("3") && cylinderPlayer.activeInHierarchy == false) {
			if (cubePlayer.activeInHierarchy == true) {
				cubePlayer.SetActive (false);
				cylinderPlayer.SetActive (true);
			} else if (pyramidPlayer.activeInHierarchy == true) {
				pyramidPlayer.SetActive (false);
				cylinderPlayer.SetActive (true);
			}
		}
	}
}
