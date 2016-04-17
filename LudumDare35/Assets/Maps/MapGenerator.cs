using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGenerator : MonoBehaviour {
	public TextAsset map;
	public int cellSize = 35;
	public GameObject[] obstacles;
	public GameObject currentObstacle;
	private List <CellInfo> cellList;
	private int lastLane;
	private int lastObject = 0;

	void Start() {
		for (int i = 0; i < 10; i++) {
			SpawnObstacle ();
		}
	}

	void Update() {
		
	}

	public void SpawnObstacle() {
		//int randomLane = Random.Range (0, 3);
		int spawnPosition;
		int randomObject = Random.Range (0, 3);
		int coordX = (int)currentObstacle.transform.GetChild (0).transform.GetChild (1).position.x;

		//if (lastLane == randomLane) {
			if (lastObject == randomObject) {
				spawnPosition = Random.Range (36, 72);
			} else {
				spawnPosition = Random.Range (72, 82);
			}
		//}

		currentObstacle = (GameObject)Instantiate (obstacles[randomObject], /*currentObstacle.transform.GetChild (0).transform.GetChild (1).position*/ new Vector3(coordX+spawnPosition, 0f, 0f), Quaternion.identity);
	}
}
