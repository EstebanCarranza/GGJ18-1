using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedLife : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BajarVida(float vida){
		Image imagen = GetComponent<Image>();
		imagen.fillAmount = vida * 0.01f;
	}
}
