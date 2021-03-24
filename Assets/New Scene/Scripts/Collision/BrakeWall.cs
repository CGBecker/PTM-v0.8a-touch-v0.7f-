using UnityEngine;
using System.Collections;

public class BrakeWall : MonoBehaviour {


	public GameObject Wall;
	public GameObject Pieces;



	public void OnTriggerEnter2D (Collider2D other){

		Debug.Log ("CollidioQualquer");

		if (other.gameObject.tag == "HammerAttack") {
			Pieces.SetActive(true);
			Wall.SetActive (false);
			Debug.Log("CollidioHammer");
		
		}
	}
}
