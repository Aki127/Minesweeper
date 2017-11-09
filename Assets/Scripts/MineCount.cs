using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MineCount : MonoBehaviour {

	public Text text;
	int mines;

	// Use this for initialization
	void Start () {
		mines = 10; //多分この処理よくない。ボタンコントローラーに混ぜるとよくない気がするしボタンほとの地雷数の指定ができないるもしくは混乱する
		text = GetComponent<Text> (); 
		
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "Game") {
			string minesText = (mines).ToString ();
			text.text = minesText;
		}
		
	}
}
