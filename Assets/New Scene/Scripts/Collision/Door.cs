using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public Animation DoorAnim;
	private bool isOpen = false;
	private bool GotKey = false;
	public ItemCatch KeyChecker;



	void Start () {
	
	}

	void Update(){
		GotKey = KeyChecker.KeyChecker;
	
	}
	
	public void OnTriggerEnter2D (Collider2D other){

		Debug.Log (GotKey);
		if (other.gameObject.tag == "Player" && GotKey == true) {
			if(isOpen == false){
				DoorAnim.Play ();
				isOpen = true;
			}
		}
	}

}
