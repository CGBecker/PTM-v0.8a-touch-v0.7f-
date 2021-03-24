//Aplicar esse script dentro do botoes direita e esquerda

using UnityEngine;
using System.Collections;
using UnityEngine.UI;//Serve para funcionar os inputs dos botoes
using UnityEngine.EventSystems;//Se para reconhecer os inputs nos botoes

public class buttonCtrl : MonoBehaviour,  IPointerDownHandler, IPointerUpHandler {// Sem IPointerDownHandler, IPointerUpHandle aqui as funçoes OnPointerDown e OnPointerUp nao funcionam
	public GameObject  avatar;
	// Use this for initialization
	void Start () {
		avatar = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnPointerDown (PointerEventData eventData) //Funçao para quando o jogador mantem o botao precionado 
	{
		if (gameObject.name == "Right") {//se o botao for o direito
			avatar.GetComponent<Walk> ().btnValue = 1;// <-- Alterando valores do avatar
			avatar.GetComponent<Walk> ().isRight = true;;// <-- Alterando valores do avatar
			avatar.GetComponent<Walk> ().go = true;;// <-- Alterando valores do avatar
			avatar.GetComponent<InputState> ().direction = Directions.Right;;// <-- Alterando valores do avatar
		}

		if (gameObject.name == "Left") {
			avatar.GetComponent<Walk> ().btnValue = -1;	
			avatar.GetComponent<Walk> ().isLeft = true;
			avatar.GetComponent<Walk> ().go = true;
			avatar.GetComponent<InputState> ().direction = Directions.Left;
		}

		if (gameObject.name == "Jump") {
			avatar.GetComponent<Jump> ().JumpBtn = true;
			avatar.GetComponent<WallJump>().JumpBtn = true;
		
		}


	}

	public void OnPointerUp (PointerEventData eventData) //funçao para quando o jogador soltar a merda do botao
	{
		if (gameObject.name == "Left" || gameObject.name == "Right") {
			avatar.GetComponent<Walk> ().go = false;
		}
		if (gameObject.name == "Jump") {
			avatar.GetComponent<Jump>().JumpBtn = false;
			avatar.GetComponent<WallJump>().JumpBtn = false;
		}
		
	

	}

}
