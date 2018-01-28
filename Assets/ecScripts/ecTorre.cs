using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ecTorre : MonoBehaviour {

	// Use this for initializatio
	public int indice = 0;
	public GameObject torre1;
	public GameObject torre2;
	public GameObject torre3;
	public GameObject torre4;
	public GameObject torre5;
	public GameObject torre6;

	/*public bool usoTorre1 = 0;
	public bool usoTorre2 = 0;
	public bool usoTorre3 = 0;
	public bool usoTorre4 = 0;
	public bool usoTorre5 = 0;
	public bool usoTorre6 = 0;*/

	public int torreta = 1;

	public float secs = 0;

	public float coolDown = 10.5F;

	public float coolDownTimer1 = 0;
	public float coolDownTimer2 = 0;
	public float coolDownTimer3 = 0;
	public float coolDownTimer4 = 0;
	public float coolDownTimer5 = 0;
	public float coolDownTimer6 = 0;

	void Start () {
		
	}

	public float speed = 100;
	bool izqDer = false;

	void rotate_object (GameObject obj, bool direccion)
	{
		if (direccion) 
		{
			
			obj.transform.Rotate (Vector3.forward, speed * Time.deltaTime);
		}
		else 
		{
			
			obj.transform.Rotate (Vector3.forward, -speed * Time.deltaTime);
		}
	}

	// Update is called once per frame
	void Update () {

		if (coolDownTimer1 < 0) {
			coolDownTimer1 = 0;
		}
		if (coolDownTimer1 > 0) {
			coolDownTimer1 -= Time.deltaTime;
		}

		if (coolDownTimer2 < 0) {
			coolDownTimer2 = 0;
		}
		if (coolDownTimer2 > 0) {
			coolDownTimer2 -= Time.deltaTime;
		}

		if (coolDownTimer3 < 0) {
			coolDownTimer3 = 0;
		}
		if (coolDownTimer3 > 0) {
			coolDownTimer3 -= Time.deltaTime;
		}

		if (coolDownTimer4 < 0) {
			coolDownTimer4 = 0;
		}
		if (coolDownTimer4 > 0) {
			coolDownTimer4 -= Time.deltaTime;
		}

		if (coolDownTimer5 < 0) {
			coolDownTimer5 = 0;
		}
		if (coolDownTimer5 > 0) {
			coolDownTimer5 -= Time.deltaTime;
		}

		if (coolDownTimer6 < 0) {
			coolDownTimer6 = 0;
		}
		if (coolDownTimer6 > 0) {
			coolDownTimer6 -= Time.deltaTime;
		}
	
		if (Input.GetKey (KeyCode.LeftArrow)) {izqDer = true;}
		if (Input.GetKey (KeyCode.RightArrow)) {izqDer = false;}

		/*if (Input.GetKey (KeyCode.Q) ) {rotate_object (torre1, izqDer); secs = 60;}
		else if (Input.GetKey (KeyCode.A)) {rotate_object (torre2, izqDer); secs = 60;}
		else if (Input.GetKey (KeyCode.S) ) {rotate_object (torre3, izqDer); secs = 60;}
		else if (Input.GetKey (KeyCode.D) ) {rotate_object (torre4, izqDer); secs = 60;}
		else if (Input.GetKey (KeyCode.E) ) {rotate_object (torre5, izqDer); secs = 60;}
		else if (Input.GetKey (KeyCode.W) ) {rotate_object (torre6, izqDer); secs = 60;}*/

		switch (torreta) {
		case 1:
			if (Input.GetKey (KeyCode.Q) && coolDownTimer1 == 0) {	
				if (Input.GetKey (KeyCode.Q) && coolDownTimer1 > 5 && coolDownTimer1 <= 10) {
					rotate_object (torre1, izqDer);
				}
				coolDownTimer1 = coolDown; } 
			else	torreta = 0;
			break;
		case 2:
			if (Input.GetKey (KeyCode.A) && coolDownTimer2 == 0) {	
				if (Input.GetKey (KeyCode.A) && coolDownTimer2 > 5 && coolDownTimer2 <= 10) {
					rotate_object (torre2, izqDer);
				}
				coolDownTimer2 = coolDown; } 
			else	torreta = 0;
			break;
		case 3:
			if (Input.GetKey (KeyCode.S) && coolDownTimer3 == 0) {	
				if (Input.GetKey (KeyCode.S) && coolDownTimer3 > 5 && coolDownTimer3 <= 10) {
					rotate_object (torre3, izqDer);
				}
				coolDownTimer3 = coolDown; }
			else	torreta = 0;
			break;
		case 4:
			if (Input.GetKey (KeyCode.D) && coolDownTimer4 == 0) {	
				if (Input.GetKey (KeyCode.D) && coolDownTimer4 > 5 && coolDownTimer4 <= 10) {
					rotate_object (torre4, izqDer);
				}
				coolDownTimer4 = coolDown; } 
			else	torreta = 0;
			break;
		case 5:
			if (Input.GetKey (KeyCode.E) && coolDownTimer5 == 0) {	
				if (Input.GetKey (KeyCode.E) && coolDownTimer5 > 5 && coolDownTimer5 <= 10) {
					rotate_object (torre5, izqDer);
				}
				coolDownTimer5 = coolDown; } 
			else	torreta = 0;
			break;
		case 6:
			if (Input.GetKey (KeyCode.W) && coolDownTimer6 == 0) {
				if (Input.GetKey (KeyCode.W) && coolDownTimer6 > 5 && coolDownTimer6 <= 10) {
					rotate_object (torre6, izqDer);
				}
				coolDownTimer6 = coolDown; } 
			else	torreta = 0;
			break;
		/*case 6:
			if (Input.GetKey (KeyCode.W) && coolDownTimer6 == 0) {
				rotate_object (torre6, izqDer);
				coolDownTimer6 = coolDown; } 
			else	torreta = 0;
			break; */
		default:
			if (Input.GetKey (KeyCode.Q) && coolDownTimer1 > 5 && coolDownTimer1 < 10) {
				rotate_object (torre1, izqDer);
			} else if (Input.GetKey (KeyCode.Q) && coolDownTimer1 >= 10) {
				torreta = 1; 
			} else if (Input.GetKey (KeyCode.Q)) {
				torreta = 1;
			}
			if (Input.GetKey (KeyCode.A) && coolDownTimer2 > 5 && coolDownTimer2 < 10) {
				rotate_object (torre2, izqDer); 
			} else if (Input.GetKey (KeyCode.A) && coolDownTimer2 >= 10) {
				torreta = 2;
			} else if (Input.GetKey (KeyCode.A)) {
				torreta = 2;
			}
			if (Input.GetKey (KeyCode.S) && coolDownTimer3 > 5 && coolDownTimer3 < 10) {
				rotate_object (torre3, izqDer); 
			} else if (Input.GetKey (KeyCode.S) && coolDownTimer3 >= 10) {
				torreta = 3;
			} else if (Input.GetKey (KeyCode.S)) {
				torreta = 3;
			}
			if (Input.GetKey (KeyCode.D) && coolDownTimer4 > 5 && coolDownTimer4 < 10) {
				rotate_object (torre4, izqDer); 
			} else if (Input.GetKey (KeyCode.D) && coolDownTimer4 >= 10) {
				torreta = 4;
			} else if (Input.GetKey (KeyCode.D)) {
				torreta = 4;
			}
			if (Input.GetKey (KeyCode.E) && coolDownTimer5 > 5 && coolDownTimer5 < 10) {
				rotate_object (torre5, izqDer); 
			} else if (Input.GetKey (KeyCode.E) && coolDownTimer5 >= 10) {
				torreta = 5;
			} else if (Input.GetKey (KeyCode.E)) {
				torreta = 5;
			}
			if (Input.GetKey (KeyCode.W) && coolDownTimer6 > 5 && coolDownTimer6 < 10) {
				rotate_object (torre6, izqDer); 
			} else if (Input.GetKey (KeyCode.W) && coolDownTimer6 >= 10){
				torreta = 6;
			} else if (Input.GetKey (KeyCode.W)) {
				torreta = 6;
			}
			/*if (Input.GetKey (KeyCode.W) && coolDownTimer6 > 5) {
				rotate_object (torre6, izqDer); 
			} else if (Input.GetKey (KeyCode.W))
				torreta = 6;*/

			break;
		}

		if (secs > 0) {	secs--; }
	}

	public Vector3 center;
	public GameObject bala;

	void spawn_balas()
	{
		Vector3 pos;

		pos = center + new Vector3(0,0, 0);
		Instantiate (bala, pos, Quaternion.identity);
	}




}
