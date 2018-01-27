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
	public float visionRadius = 5;
	public float vida = 10;
	public bool activar_movimiento = true;

	public Vector3 center;
	public GameObject bala;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");

		// Guardamos nuestra posición inicial
		initialPosition = transform.position;
		spawn_bala ();
	}



	// Update is called once per frame
	void Update () 
	{
		mover_nave ();
		mover_bala ();
	}

	void spawn_bala()
	{
		Vector3 pos;
		pos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
		Instantiate (bala, pos, Quaternion.identity);		

	}
	void mover_nave()
	{
		if (activar_movimiento) {
			// Por defecto nuestro objetivo siempre será nuestra posición inicial
			Vector3 target = initialPosition;

			// Pero si la distancia hasta el jugador es menor que el radio de visión el objetivo será él
			float dist = Vector3.Distance (player.transform.position, transform.position);

			if (dist > visionRadius)
				target = player.transform.position;

			// Finalmente movemos al enemigo en dirección a su target
			float fixedSpeed = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target, fixedSpeed);
			/*
			Vector3 targetDir = target.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			Debug.DrawRay(transform.position, newDir, Color.red);
			transform.rotation = Quaternion.LookRotation(newDir);*/

			// Y podemos debugearlo con una línea
			Debug.DrawLine (transform.position, target, Color.green);
		}
	}

	void mover_bala()
	{
		bala.transform.position = this.transform.position;
		/*
		// Por defecto nuestro objetivo siempre será nuestra posición inicial
		Vector3 target = initialPosition;

		// Pero si la distancia hasta el jugador es menor que el radio de visión el objetivo será él
		float dist = Vector3.Distance(player.transform.position, bala.transform.position);
		if (dist > visionRadius) 
			target = player.transform.position;

		// Finalmente movemos al enemigo en dirección a su target
		float fixedSpeed = speed*Time.deltaTime;
		bala.transform.position = Vector3.MoveTowards(bala.transform.position, target, fixedSpeed);

		// Y podemos debugearlo con una línea
		Debug.DrawLine(bala.transform.position, target, Color.green);*
		*/
	}
}
