using UnityEngine;
using System.Collections;

public class WallJump : AbstractBehavior {
	public  bool    jumpingOffWall;
	public  Vector2 jumpVelocity = new Vector2(50, 200);
	public  float   resetDelay   = .2f;
	private float   timeElapsed  = 0;
	public bool JumpBtn = false;

    public AudioSource JumpSound2;
	
	public void Update() {
		if (collisionState.onWall && !collisionState.standing) {
			//bool canJump = inputState.GetButtonValue(inputButtons[0]);
			bool canJump = JumpBtn;
			if (canJump && !jumpingOffWall) {
                JumpSound2.Play();
				ToggleScripts(false);
				inputState.direction = inputState.direction == Directions.Right ? Directions.Left : Directions.Right;
				body2d.velocity      = new Vector2(jumpVelocity.x * (float)inputState.direction, jumpVelocity.y);
				jumpingOffWall       = true;
			}
		}

		if (jumpingOffWall) {
			timeElapsed += Time.deltaTime;

			if (timeElapsed > resetDelay) {
				ToggleScripts(true);
				jumpingOffWall = false;
				timeElapsed    = 0;
			}
		}
	}
}
