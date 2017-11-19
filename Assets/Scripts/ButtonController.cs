using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
	//ボタンを押した時にpublic変数に値を追加できないからシーンをゲームモードの数だけ作る楽な道を選んだ。

		public void GameStartEasy(){
		SceneManager.LoadScene ("GameEasy");

	}
		public void GameStartNormal(){
		SceneManager.LoadScene ("GameNormal");

	} 
		public void GameStratDifficult (){
		SceneManager.LoadScene ("GameDifficult");
	}
		public void Result(){
		SceneManager.LoadScene ("Result");
	}
		public void Home(){
		SceneManager.LoadScene ("Start");



	
		
	}
}
