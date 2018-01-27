using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre_Disparo : MonoBehaviour {

	//List<GameObject> targetedEnemies;

	//private jarz_enemy target;
	//private Queue<jarz_enemy> enemy = new Queue<jarz_enemy> ();

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerStay(Collider other){
		//enemy.
		if(other.gameObject.CompareTag("Enemy")){
			//targetedEnemies.Add (other.gameObject);
		//	target = other.GetComponent<Enemy>();
		}

	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag("Enemy")) {
			//targetedEnemies.Remove (other.gameObject);
		}
	}

	public float speed = 20;
	// Update is called once per frame

	void Update () {
		
		
		/*if(Input.GetMouseButtonDown (0)){
			if(Input.GetKey (KeyCode.LeftArrow))
				transform.Rotate (Vector3.forward, speed*Time.deltaTime);
			if (Input.GetKey (KeyCode.RightArrow))
				transform.Rotate (Vector3.forward, -speed*Time.deltaTime);
			
		}*/
	}
}
