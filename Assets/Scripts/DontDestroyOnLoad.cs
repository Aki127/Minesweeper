using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	void Awake() {
		//このスクリプトがアタッチされているオブジェクトはシーン遷移時も生き残る
		DontDestroyOnLoad(this.gameObject);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
