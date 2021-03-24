using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {

	public GameObject pauseMenu;
	public bool isMenuOn = false;

	public GameObject Controls1;
	public bool isControlOn;

	void Start () {

		pauseMenu.SetActive (false);
	
	}
	

	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Escape) && isMenuOn == false){
			pauseMenu.SetActive(true);
			isMenuOn = true;
			Time.timeScale = 0;
			return;

		}
		if (Input.GetKeyDown (KeyCode.Escape) && isMenuOn == true) {
			pauseMenu.SetActive(false);
			isMenuOn = false;
			Time.timeScale = 1;
			return;
		}

	}

	public void Continue(){
		pauseMenu.SetActive (false);
		isMenuOn = false;
		Time.timeScale = 1;


	}
	public void Controls(){
		if (isControlOn == false) {
			Controls1.SetActive (true);
			isControlOn = true;
			return;
		}
		if (isControlOn == true) {
			Controls1.SetActive (false);
			isControlOn = false;
			return;
		}
	}

	public void Exit(){
		Application.Quit();

	}

	public void Reset(){

		Application.LoadLevel (Application.loadedLevel);
	}

}
