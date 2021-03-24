using UnityEngine;
using System.Collections;

public class Jump : AbstractBehavior {
	public    GameObject dustEffectPrefab;
	public    float      jumpSpeed      = 200f;
	public    float      jumpDelay      = .1f;
	public    int        jumpCount      = 2;
	public    bool       JumpBtn = false;
	protected float      lastJumpTime   = 0;
	protected int        jumpsRemaining = 0;

    public AudioSource JumpSound1;
	
	protected virtual void Update () {
		bool canJump = JumpBtn;
		float holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

		if (collisionState.standing) {
			if (canJump && holdTime < .1f) {
				jumpsRemaining = jumpCount - 1;
				OnJump();
			}
		} else {
			if (canJump && holdTime < .1f && Time.time - lastJumpTime > jumpDelay) {
				if (jumpsRemaining > 0) {
					OnJump();
					jumpsRemaining--;
					var clone                = Instantiate(dustEffectPrefab);
					clone.transform.position = transform.position;
				}
			}
		}
	}

	protected virtual void OnJump() {
        JumpSound1.Play();
		Vector2 vel     = body2d.velocity;
		lastJumpTime    = Time.time;
		body2d.velocity = new Vector2(vel.x, jumpSpeed);
	}


}
