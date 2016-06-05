using UnityEngine;
using System.Collections;

public class CameraMoveMenu : MonoBehaviour {

	int rotCamera = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.rotation.y > 30) {
			rotCamera = -1;
		}
		if (this.transform.rotation.y > 30) {
			rotCamera = 1;
		}
		this.transform.Rotate (new Vector3 (0, rotCamera * Time.deltaTime, 0));
	}
}
