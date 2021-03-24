using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public GameObject BotaoStart;
	public GameObject BotaoExit;
	public GameObject BotaoCreditos;
	public GameObject BotaoVoltar;
	public GameObject Creditos1;
	public GameObject BlackScreen;


	public void StartGame(){
		Application.LoadLevel (Application.loadedLevel + 1);

	}

	public void Exit(){
		Application.Quit();

	}

	public void Creditos(){
		BotaoExit.SetActive (false);
		BotaoStart.SetActive (false);
		BotaoCreditos.SetActive (false);
		BotaoVoltar.SetActive (true);
		Creditos1.SetActive (true);
        BlackScreen.SetActive(true);


	}

	public void Voltar(){
		BotaoExit.SetActive (true);
		BotaoStart.SetActive (true);
		BotaoCreditos.SetActive (true);
		BotaoVoltar.SetActive (false);
		Creditos1.SetActive (false);
        BlackScreen.SetActive(false);


    }
}
