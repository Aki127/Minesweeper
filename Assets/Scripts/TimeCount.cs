using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour { 

	float time; //時間を記録する変数
	Text text;

	// Use this for initialization
	 void Start () {
		time = 0;
		text = GetComponent<Text> (); 
	}

	// Update is called once per frame
	 void Update () {
		time += Time.deltaTime;  //毎フレームの時間を加算。
		string secText;
		secText = Mathf.Ceil(time).ToString ();//ToStringでint⇨stringに変換。小数点以下を除外
		text.text = secText;

	}
}