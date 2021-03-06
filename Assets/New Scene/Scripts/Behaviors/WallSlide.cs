using UnityEngine;
using System.Collections;

public class WallSlide : StickToWall {
	public  GameObject dustPrefab;
	public  float      slideVelocity   = -5f;
	public  float      slideMultiplier = 5f;
	public  float      dustSpawnDelay  = .5f;
	private float      timeElapsed     = 0f;
	
	protected override void Update() {
		base.Update ();

		if (onWallDetected && !collisionState.standing) {
			float velY = slideVelocity;

			if (inputState.GetButtonValue(inputButtons[0]))
				velY *= slideMultiplier;

			body2d.velocity = new Vector2(body2d.velocity.x, velY);

			if (timeElapsed > dustSpawnDelay) {
				var dust = Instantiate(dustPrefab);

				Vector3 pos = transform.position;
				pos.y      += 2;

				dust.transform.position   = pos;
				dust.transform.localScale = transform.localScale;

				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	protected override void OnStick() {
		body2d.velocity = Vector2.zero;
	}

	protected override void OffWall() {
		timeElapsed = 0;
	}
}
