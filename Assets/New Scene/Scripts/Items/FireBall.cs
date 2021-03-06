using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {
	public Vector2 initialVelocity = new Vector2(100, -100);
	public int bounces = 3;
	private Rigidbody2D body2d;

	void Awake(){
		body2d = GetComponent<Rigidbody2D>();
	}


	public void Start() {
		float startVelX = initialVelocity.x * transform.localScale.x;
		body2d.velocity = new Vector2(startVelX, initialVelocity.y);
	}

	public void OnCollisionEnter2D(Collision2D target) {
		if (target.gameObject.transform.position.y < transform.position.y) {
			bounces--;
		}

		if (bounces <= 0)
			Destroy(gameObject);
	}
}
