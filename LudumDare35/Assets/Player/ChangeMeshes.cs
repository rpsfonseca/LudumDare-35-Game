using UnityEngine;
using System.Collections;

public class ChangeMeshes : MonoBehaviour {

	public GameObject cubePlayer;
	public GameObject pyramidPlayer;
	public GameObject cylinderPlayer;

	Mesh initialMesh;
	Mesh swapMesh;

	//GameObject theTarget;

	int onePressed = 0;

	// Use this for initialization
	void Update () {
		if (Input.GetKeyDown ("1") && onePressed == 0) {
			//onePressed++;

			if (cubePlayer.activeInHierarchy == true) {
				cubePlayer.SetActive (false);
				pyramidPlayer.SetActive (true);
			} else if (pyramidPlayer.activeInHierarchy == true) {
				cubePlayer.SetActive (true);
				pyramidPlayer.SetActive (false);
			}
			//theTarget = initialObject;


			/*initialMesh = initialObject.GetComponent<MeshFilter> ().mesh;
			swapMesh = swapObject.GetComponent<MeshFilter> ().sharedMesh;

			theTarget.GetComponent<MeshFilter> ().mesh = swapMesh;*/

			//theTarget.GetComponent <GameObject> () = swapObject.GetComponent<GameObject> ();
		} else if(Input.GetKeyDown ("2") && onePressed == 1) {
			onePressed--;
			//theTarget.GetComponent<MeshFilter> ().mesh = initialMesh;
		}
	}
}
