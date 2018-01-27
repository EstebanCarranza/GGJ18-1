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
	
		if (Input.GetKey (KeyCode.LeftArrow)) {izqDer = true;}
		if (Input.GetKey (KeyCode.RightArrow)) {izqDer = false;}
		if (Input.GetKey (KeyCode.Q)) {rotate_object (torre1, izqDer);}
		if (Input.GetKey (KeyCode.A)) {rotate_object (torre2, izqDer);}
		if (Input.GetKey (KeyCode.S)) {rotate_object (torre3, izqDer);}
		if (Input.GetKey (KeyCode.D)) {rotate_object (torre4, izqDer);}
		if (Input.GetKey (KeyCode.E)) {rotate_object (torre5, izqDer);}
		if (Input.GetKey (KeyCode.W)) {rotate_object (torre6, izqDer);}

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
