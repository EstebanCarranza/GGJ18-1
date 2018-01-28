using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ecTiemp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public Text Tempo; 
	public float tiempo = 0.0f;



	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		Tempo.text = "Tiempo:" + " " + tiempo.ToString ("f0");

	}
}
