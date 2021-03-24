using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemCatch : MonoBehaviour {

	public Text CoinsText;
	public int  Coins;

	public AudioSource Plim1;

	public GameObject HammerImage;

	public GameObject DaggerImage;

	public GameObject RopeImage;

	public GameObject KeyImage;
	public bool       KeyChecker = false;
    public AudioSource KeySound1;

	public GameObject Winner;

	void Start () {
	
		Time.timeScale = 1;

	}
	

	void Update () {
	
	}

	public void OnTriggerEnter2D (Collider2D hit){
		if (hit.gameObject.tag == "Key") {
			KeyImage.SetActive(true);
			KeyChecker = true;
            KeySound1.Play();
		
		}
		if (hit.gameObject.tag == "Coin") {
			Coins++;
			CoinsText.text = " " + Coins;
			Plim1.Play();
			
		}
		if (hit.gameObject.tag == "Hammer") {
			HammerImage.SetActive(true);
            KeySound1.Play();
        }
		if (hit.gameObject.tag == "Dagger") {
			DaggerImage.SetActive(true);
            KeySound1.Play();

        }
		if (hit.gameObject.tag == "Tesouro") {
			Winner.SetActive(true);
			Time.timeScale = 0;
			
		}
		if (hit.gameObject.tag == "Rope") {
			RopeImage.SetActive(true);
            KeySound1.Play();

        }


	}

	public void OnTriggerExit2D (Collider2D other){
	
	
	}

	public void NextLevel(){

		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
