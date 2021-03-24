using UnityEngine;
using System.Collections;

public class ComportaEffect : MonoBehaviour {

	private Animation Efeito1;

	void Start () {
	
		Efeito1 = GetComponent<Animation> ();

	}
	
	private void OnTriggerEnter2D (Collider2D other){
	
		if (other.gameObject.tag == "Comporta") {
			Efeito1.Play();
		
		}
	}

}
