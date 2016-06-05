using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void loadScene(string name){
		StartCoroutine (loadLevel ());
	}

	public void quitGame(){
		Application.Quit();
	}

	public IEnumerator loadLevel(){
		yield return new WaitForSeconds (1.0f);
		SceneManager.LoadScene(1);
	}
}
