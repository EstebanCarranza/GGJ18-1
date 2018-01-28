using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ecCode;

public class ecColision : MonoBehaviour {

	public float vida;
	public objectTypeCollision tipoObj;
	public float danioBalaNormal = 5;
	public float danioNaveNormal = 15;
	public float timeLeft = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (vida <= 0) {
			GameOver ();
		} else {
			timeLeft += Time.deltaTime;
		}

	}


	/*
	void OnTriggerEnter2D()
	{
		Debug.Log("trigger");
	}
	*/
	bool GameOverV = false;
	void GameOver()
	{
		GameOverV = true;
	}


	void OnTriggerEnter2D(Collider2D coll)
	{

		switch (tipoObj) 
		{
		case objectTypeCollision.nave_principal:
			if (coll.gameObject.CompareTag ("enemy")) 
			{
				vida -= danioBalaNormal;
				DestroyObject (coll.gameObject);
			}

			if (coll.gameObject.CompareTag ("bala_enemy")) {
				vida -= danioBalaNormal;
				//coll.gameObject.GetType (ecNaveEnemiga);
				DestroyObject (coll.gameObject);
			}

			break;
		case objectTypeCollision.torre:
			break;
		case objectTypeCollision.bala_torre:
			if (coll.gameObject.CompareTag ("enemy")) 
			{
				DestroyObject (coll.gameObject);
			}

			if (coll.gameObject.CompareTag ("bala_enemy")) {
				DestroyObject (coll.gameObject);
			}
			break;
		case objectTypeCollision.bala_enemiga:
			break;

		case objectTypeCollision.nave_enemiga:
			break;
		}



	}

}
