using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {

	public void RestartMenu() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
