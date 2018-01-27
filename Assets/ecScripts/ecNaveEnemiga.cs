using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ecNaveEnemiga : MonoBehaviour {

	// Variable para guardar al jugador
	GameObject player;

	// Variable para guardar la posición inicial
	Vector3 initialPosition;
	Vector3 stopPosition;
	public float speed = 10;
	public float visionRadius = 50;
	public float vida = 10;


	public Vector3 center;

	public GameObject base_principal;
	public GameObject bala;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");

		// Guardamos nuestra posición inicial
		initialPosition = transform.position;
		//initialPosition = base_principal.transform.position;
		//spawn_bala ();
	}



	// Update is called once per frame
	void Update () 
	{
		//initialPosition = new Vector3(0,0,0);
		mover_nave ();
		//mover_bala ();
	}


	void mover_nave()
	{
		// Por defecto nuestro objetivo siempre será nuestra posición inicial
		Vector3 target = initialPosition;

		// Pero si la distancia hasta el jugador es menor que el radio de visión el objetivo será él
		float dist = Vector3.Distance(player.transform.position, transform.position);
		if (dist > visionRadius) target = player.transform.position;

		// Finalmente movemos al enemigo en dirección a su target
		float fixedSpeed = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

		// Y podemos debugearlo con una línea
		Debug.DrawLine(transform.position, target, Color.green);
	}


}
