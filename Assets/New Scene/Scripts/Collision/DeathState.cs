using UnityEngine;
using System.Collections;

public class DeathState : MonoBehaviour {


	public GameObject DeathScreen;

    public AudioSource DeathAudio;


    void Start(){DeathScreen.SetActive (false);}

	public void OnTriggerEnter2D (Collider2D hit){
	
		if (hit.gameObject.tag == "Espinhos") {
			Death ();
			return;
		}
	
	}
	

	public void Death(){

		DeathScreen.SetActive (true);
		Time.timeScale = 0;
        DeathAudio.Play();

	}
	public void ResetLevel(){

		Application.LoadLevel (Application.loadedLevel);

	}
}
