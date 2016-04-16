using UnityEngine;
using System.Collections;

public class ChangeMeshes : MonoBehaviour {

	public GameObject initialObject;
	public GameObject swapObject;

	Mesh initialMesh;
	Mesh swapMesh;

	GameObject theTarget;

	int onePressed = 0;

	// Use this for initialization
	void Update () {
		if (Input.GetKeyDown ("1") && onePressed == 0) {
			onePressed++;
			theTarget = initialObject;

			initialMesh = initialObject.GetComponent<MeshFilter> ().mesh;
			swapMesh = swapObject.GetComponent<MeshFilter> ().sharedMesh;

			theTarget.GetComponent<MeshFilter> ().mesh = swapMesh;
		} else if(Input.GetKeyDown ("1") && onePressed == 1) {
			onePressed--;
			theTarget.GetComponent<MeshFilter> ().mesh = initialMesh;
		}
	}
}
