using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ecTiempo : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	public Text Tempo; 
	public Text Label;
	public float tiempo = 0.0f;



	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		Tempo.text = "Tiempo:" + " " + tiempo.ToString ("f0");
		/*
		if (Time.timeScale == 0) {


			if (Label.text == "")
			{
				Tempo.text = "Tu puntacion: " + tiempo.ToString("f0");
			}
		}*/

}
}