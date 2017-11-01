using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

		public void GameStart(){
		SceneManager.LoadScene ("Game");
	}
		public void Result(){
		SceneManager.LoadScene ("Result");
	}
		public void Home(){
		SceneManager.LoadScene ("Start");
	


	
		
	}
}
