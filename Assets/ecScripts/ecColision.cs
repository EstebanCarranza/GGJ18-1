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
	public bool usarTiempo = false;
	private int proyectil_original = 0;
	private RedLife LifeGUI;

	// Use this for initialization
	void Start () {
		GameObject hand;
		hand = GameObject.Find("RedLife");
	
		if (hand != null) {
			LifeGUI = hand.GetComponent<RedLife>();
			LifeGUI.BajarVida (100);
		}
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
			if (coll.gameObject.CompareTag ("enemy")) {
				vida -= danioBalaNormal;

				DestroyObject (coll.gameObject);
			}

			if (coll.gameObject.CompareTag ("bala_enemy")) {
				vida -= danioBalaNormal;
				//coll.gameObject.GetType (ecNaveEnemiga);
				DestroyObject (coll.gameObject);
			}
			LifeGUI.BajarVida (vida);

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

		case objectTypeCollision.destino_bala_torre:
			{
				if (coll != null)
				if (coll.gameObject != null)
				if (coll.gameObject.CompareTag ("bala_torre"))
				if (proyectil_original >= 1)
					DestroyObject (coll.gameObject);
				else 
				{
					proyectil_original++;
					coll.transform.position += new Vector3(0,1000000,0);
				}
			}
			break;
		}



	}

}
