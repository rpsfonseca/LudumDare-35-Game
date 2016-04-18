using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

public class MapGenerator : MonoBehaviour {
	public TextAsset map;
	public int cellSize = 35;
	public GameObject[] obstacles;
	public GameObject currentObstacle;
	private int lastLane;
	private int lastObject = 0;
	private int sameObjectCount = 0;

	void Start() {
		/*for (int i = 0; i < 10; i++) {
			SpawnObstacle ();
		}*/
	}

	void Update() {
		int quantity = GameObject.FindGameObjectsWithTag ("Obstacle_Cube").Length;
		quantity += GameObject.FindGameObjectsWithTag ("Obstacle_Pyramid").Length;
		quantity += GameObject.FindGameObjectsWithTag ("Obstacle_Cylinder").Length;

		if (quantity <= 6) {
			for (int i = 0; i < 6; i++) {
				SpawnObstacle ();
			}
		}
	}

	public void SpawnObstacle() {
		int randomLane = Random.Range (0, 3);
		int spawnPosition;
		int randomObject = Random.Range (0, 3);
		int coordX = (int)currentObstacle.transform.GetChild (0).transform.GetChild (1).position.x;

		//if (lastLane == randomLane) {
		if (sameObjectCount == 2 && randomObject == lastObject) { // TODO: change sameObjectCount to 3, by instanciating first cube with code
			/*int[] validObjects = new int[2];
			int j = 0;
			for (int i = 0; i < obstacles.Count; i++) {
				if (i != lastObject) {
					validObjects [j] = i;
					j++;
				}
			}
			randomObject = validObjects [Random.Range (0, j)];*/
			sameObjectCount = 0;
			while (randomObject == lastObject) {
				randomObject = Random.Range (0, obstacles.Length);
			}

			spawnPosition = Random.Range (72, 82);
		} else {
			if (lastObject == randomObject) {
				sameObjectCount++;
				if (lastLane == randomLane) {
					spawnPosition = Random.Range (36, 72);
				} else {
					spawnPosition = Random.Range (108, 118);
				}
			} else {
				if (lastLane == randomLane) {
					spawnPosition = Random.Range (54, 72);
				} else {
					spawnPosition = Random.Range (144, 154);
				}
			}
		}
		//}
		lastObject = randomObject;
		lastLane = randomLane;
		if (randomLane == 0) {
			currentObstacle = (GameObject)Instantiate (obstacles[randomObject], /*currentObstacle.transform.GetChild (0).transform.GetChild (1).position*/ new Vector3(coordX+spawnPosition, 0f, -60f), Quaternion.identity);
		} else if (randomLane == 1) {
			currentObstacle = (GameObject)Instantiate (obstacles[randomObject], /*currentObstacle.transform.GetChild (0).transform.GetChild (1).position*/ new Vector3(coordX+spawnPosition, 0f, 0f), Quaternion.identity);
		} else {
			currentObstacle = (GameObject)Instantiate (obstacles[randomObject], /*currentObstacle.transform.GetChild (0).transform.GetChild (1).position*/ new Vector3(coordX+spawnPosition, 0f, 60f), Quaternion.identity);
		}
	}
}
