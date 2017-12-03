using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinesController : MonoBehaviour {
	public Sprite Empty;
	// Use this for initialization
	void Start () {
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		renderer.sprite = Empty;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
