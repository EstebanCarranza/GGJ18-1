using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ecGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	bool paused = false;
	bool keyPress = false;
	void Update () 
	{
		if (Input.GetKey (KeyCode.Escape) || Input.GetKey (KeyCode.P)) {
			if (!keyPress) {
				keyPress = true;
				if (paused) {
					resume ();
				} else {
					pause ();
				}
			}

		} else {
			keyPress = false;
		}

	}

	void resume()
	{
		Label.text = "";
		paused = false;
		Time.timeScale = 1;
	}
	public Text Label;
	void pause()
	{
		Label.text = "Pausado";
		paused = true;
		Time.timeScale = 0;
	}
}
