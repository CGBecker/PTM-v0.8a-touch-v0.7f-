using UnityEngine;
using System.Collections;

public class Walk : AbstractBehavior {
	public float speed         = 50f;
	public float runMultiplier = 2f;
	public bool  running;

	public bool isRight = false;
	public bool isLeft = false;

	public bool right;
	public bool left;
	public bool go;

	public PlayerManager PlayerManagerCS;

	public float btnValue;

	public void Update() {
		running    = false;

		bool right = inputState.GetButtonValue(inputButtons[0]);
		bool left  = inputState.GetButtonValue(inputButtons[1]);
		bool run   = inputState.GetButtonValue(inputButtons[2]);

		//inputState.GetButtonValue (inputButtons [0]) = isRight;
		//inputState.GetButtonValue (inputButtons [1]) = isLeft;

		//PlayerManagerCS.inputState.absVelX 


		if (right || left || go) {
			float tmpSpeed = speed;

			//if (run && runMultiplier > 0) {
				tmpSpeed *= runMultiplier;
				running   = true;
			//}

			//float velX      = tmpSpeed * (float)inputState.direction;
			float velX      = tmpSpeed * btnValue;
			body2d.velocity = new Vector2(velX, body2d.velocity.y);
		}else{
			body2d.velocity = new Vector2(0, body2d.velocity.y);

		}






	}



	public void RightTouch(){
			isRight = true;
			Debug.Log (isRight);

			



	}
	public void LeftTouch(bool IsLeft){

			isLeft = true;
			Debug.Log (isLeft);

			

		

	}
}
