using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mine;

public class MineCount : MonoBehaviour {
    public CommonDefine commonDefine;
    public Text text;
	public int  mines = 0;

	// Use this for initialization
	void Start (){
        string gameMode;
        gameMode = commonDefine.GameDifficultType;

	}
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "Game") {
			mines = 10;
			string minesText = (mines).ToString ();
			text.text = minesText;
	
		}
	}
}
