using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel(Application.loadedLevel);
		
		}
	}
}
