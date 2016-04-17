using UnityEngine;
using System.Collections;

public class CellInfo {
	private GameObject objToInstanciate;
	private Vector3 posToInstanciate;

	public CellInfo(GameObject obj, Vector3 pos) {
		objToInstanciate = obj;
		posToInstanciate = pos;
	}

	public Vector3 GetPos() {
		return posToInstanciate;
	}

	public GameObject GetObj() {
		return objToInstanciate;
	}
}
