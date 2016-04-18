using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
	public void StartMenu() {
		SceneManager.LoadScene (1);
	}
}
