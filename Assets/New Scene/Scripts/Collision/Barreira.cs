using UnityEngine;
using System.Collections;

public class Barreira : MonoBehaviour {

	public Animation BarreiraAnim;
	private bool isUnder = false;


	void Start () {
	
	}
	

	void Update () {
	
	}

	public void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.tag == "Player") {

			if(isUnder == false){
			BarreiraAnim.Play();
			isUnder = true;
			}
		}

	}
}
