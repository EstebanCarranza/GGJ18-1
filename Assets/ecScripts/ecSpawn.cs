using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ecSpawn : MonoBehaviour {


	public GameObject enemigo;
	public Vector3 center;
	public int round = 1;
	public int multiplicador = 1;
	public int incrementoPorRound = 0;
	public int cantidadObjetos = 1;
	private int creados = 0;
	public Vector2 rangoX;
	public Vector2 rangoY;



	void spawn()
	{
		Vector3 pos;

		pos = center + new Vector3(Random.Range(rangoX.x,rangoX.y), Random.Range(rangoY.x, rangoY.y), 0);
		Instantiate (enemigo, pos, Quaternion.identity);		


	}

	// Use this for initialization
	void Start () {
		
	}

//	float velAparicion = 1;
	// Update is called once per frame

	public bool enemigosActivados = true;

	float tiempo = 0;
	public float difSpawn = 100;
	float tiempoRound = 0;
	float difRound = 10;
	void Update () {
		
		if (enemigosActivados)
		{
			if (creados < cantidadObjetos) {
				if (tiempo >= difSpawn) {
					
					spawn ();	
					creados++;
					tiempo = 0;
					tiempoRound++;

				}
				else 
				{
					tiempo++;
				}


			}

		}
	}
}
