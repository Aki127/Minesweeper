using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mine
{
   

public class ButtonController : MonoBehaviour {

		public void GameStartEasy(){
            GameDifficultTypeManager.Instance.SetGameDifficultType(CommonDefine.GameDifficultType.EASY);
        //インスタンスを所得
        SceneManager.LoadScene("Game");
            Debug.Log("EASYモードでゲームスタート");
	}
		public void GameStartNormal(){
        GameDifficultTypeManager.Instance.SetGameDifficultType(CommonDefine.GameDifficultType.NORMAL);
        SceneManager.LoadScene ("Game");
            Debug.Log("NORMALモードでゲームスタート");


	} 
		public void GameStratDifficult (){
        GameDifficultTypeManager.Instance.SetGameDifficultType(CommonDefine.GameDifficultType.DIFFICULT);
		SceneManager.LoadScene ("Game");
            Debug.Log("HARDモードでゲームスタート");
	}
		public void Result(){
		SceneManager.LoadScene ("Result");
	}
        public void Home()
        {
            SceneManager.LoadScene("Start");




        }
	}
}
