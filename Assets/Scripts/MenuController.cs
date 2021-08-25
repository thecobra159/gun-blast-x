using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	private Button btnSingle, btnMulti, btnExit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SinglePlayer(){
		SceneManager.LoadScene ("Fase 1");
	}

	public void Multiplayer(){
		SceneManager.LoadScene ("Server");
	}

	public void Exit (){
		Application.Quit ();	
	}
}
