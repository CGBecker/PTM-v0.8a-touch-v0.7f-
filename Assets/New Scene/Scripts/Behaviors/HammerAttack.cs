using UnityEngine;
using System.Collections;

public class HammerAttack : MonoBehaviour {

	public GameObject HammerAttackCollider;
	public bool HaveHammer;
	public bool IsHammering = false;

    public AudioSource AttackSound2;

	void Start () {
		HaveHammer = false;
		HammerAttackCollider.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Hammer") {
			HaveHammer = true;
			
			Debug.Log("Collidio?" + HaveHammer);
			
		}
	
	}

	void Update () {
	
		if (Input.GetKeyDown (KeyCode.G)&& HaveHammer == true) {
			Debug.Log (HaveHammer);
            AttackSound2.Play();
			HammerAttackCollider.SetActive (true);
			IsHammering = true;
			Debug.Log("Pushed G");
			//return;
			
		} else {
			HammerAttackCollider.SetActive(false);
			IsHammering = false;
			Debug.Log("Not Working");
			//return;
		}

	}
}
