using UnityEngine;
using System.Collections;

public class SplashScreenCS : MonoBehaviour {

    public float Timer;

	void Start () {
	
	}
	
	
	void FixedUpdate () {
        Timer += Time.deltaTime;

        if (Timer >= 4F) {
            Application.LoadLevel(Application.loadedLevel + 1);
        }


	}
}
