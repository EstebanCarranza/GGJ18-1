using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ecBala : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject finDisparo;
	public float fixedSpeed = 10.0F;
	public int tipoBala = 2;
	// Update is called once per frame
	void Update () {

		if (tipoBala == 2) 
		{
			transform.position = Vector3.MoveTowards (transform.position, finDisparo.transform.position, fixedSpeed*Time.deltaTime);
		}
	
	}
}
