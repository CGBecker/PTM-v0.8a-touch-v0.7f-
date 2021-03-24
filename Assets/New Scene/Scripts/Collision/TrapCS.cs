using UnityEngine;
using System.Collections;

public class TrapCS : MonoBehaviour {


	private Animator TrapAnim;
	private Animation Trap2;
	public bool isSteped = false;
	private float Timer = 0F;
	public GameObject DeathScreen;


	void Start () {
		TrapAnim = GetComponent<Animator>();
		Trap2 = GetComponent<Animation> ();
	
	}

	void OnTriggerEnter2D (Collider2D hit){
		Debug.Log ("Colidiu!!");
		if (hit.gameObject.tag == "Player") {
			//Trap2.Play ();
			isSteped = true;

		}

	}

	void Update () {

		if (isSteped == true) {
			TrapAnim.SetInteger("TrapState", 1);
			Timer += Time.deltaTime;
			Debug.Log (Timer);
		}
		if (Timer >= 0.15F) {
			DeathScreen.SetActive(true);
			Time.timeScale = 0;
		
		}
	}
}
