using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public bool isAtacking;
	public GameObject AttackCollider;
	public bool HaveDagger = false;

	public bool isOver = false;
	public float timer = 0F;

    public AudioSource AttackSound1;


	void Start () {
	

		AttackCollider.SetActive (false);


	}

	public void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Dagger") {
			HaveDagger = true;
		
		}


	
	}
	

	void Update () {
	
		if (Input.GetKeyDown (KeyCode.F) && HaveDagger == true) {
            AttackSound1.Play();
			AttackCollider.SetActive(true);
			isAtacking = true;
			isOver = true;
			//return;
		} else {
			isAtacking = false;
			if(timer >= 0.33F){
				AttackCollider.SetActive(false);
				isOver = false;
				timer = 0F;
			}
			//return;
		}
		if (isOver == true) {
			timer += Time.deltaTime;
		}


	}
}
