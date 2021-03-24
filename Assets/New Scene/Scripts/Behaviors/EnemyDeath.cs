using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

	public GameObject DeathScreen;
	public GameObject Enemy;

	public void OnTriggerEnter2D(Collider2D hit){

		if (hit.gameObject.tag == "AttackCollider") {
			//Destroy(gameObject);
			Enemy.SetActive(false);
		
		}

		if (hit.gameObject.tag == "Vulneravel") {
			DeathScreen.SetActive(true);
			Time.timeScale = 0;
		
		}

	}
	


}
