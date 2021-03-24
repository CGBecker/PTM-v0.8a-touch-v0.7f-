using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	public InputState     inputState;
	private Walk           walkBehavior;
	private Animator       animator;
	private CollisionState collisionState;
	private Duck           duckBehavior;
	private Attack         Attack;
	private HammerAttack   HammerAttack;

	public void Awake() {
		inputState     = GetComponent<InputState>();
		walkBehavior   = GetComponent<Walk>();
		animator       = GetComponent<Animator>();
		collisionState = GetComponent<CollisionState>();
		duckBehavior   = GetComponent<Duck>();
		Attack         = GetComponent<Attack> ();
		HammerAttack   = GetComponent<HammerAttack> ();
	}

	public void Update() {
		if (collisionState.standing) {
			ChangeAnimationState(0);
		}

		if (inputState.absVelX > 0) {
			ChangeAnimationState(1);

			Debug.Log("absVelX");
		}

		if (inputState.absVelY > 0) {
			ChangeAnimationState(2);

			Debug.Log ("absVelY");
		}

		animator.speed = walkBehavior.running ? walkBehavior.runMultiplier : 1;

		if (duckBehavior.ducking) {
			ChangeAnimationState(3);
		}

		if (!collisionState.standing && collisionState.onWall) {
			ChangeAnimationState(4);
		}

		if (Attack.isAtacking) {
			ChangeAnimationState(5);
		
		}
		if (HammerAttack.IsHammering) {
			ChangeAnimationState(6);
		
		}
	}

	public void ChangeAnimationState(int value){
		animator.SetInteger("AnimState", value);
	}
}
