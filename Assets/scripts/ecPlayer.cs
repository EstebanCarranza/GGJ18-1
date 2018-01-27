using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ecPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	float speed = 10;

	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
