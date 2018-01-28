using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ecTransmisionNave : MonoBehaviour {


	public Scrollbar barraTorre1;
	public Scrollbar barraTorre2;
	public Scrollbar barraTorre3;
	public Scrollbar barraTorre4;
	public Scrollbar barraTorre5;
	public Scrollbar barraTorre6;

	public float valorT1 = 0.5F;
	public float valorT2 = 0.5F;
	public float valorT3 = 0.5F;
	public float valorT4 = 0.5F;
	public float valorT5 = 0.5F;
	public float valorT6 = 0.5F;

	public float incT1 = 0.1F;
	public float incT2 = 0.1F;
	public float incT3 = 0.1F;
	public float incT4 = 0.1F;
	public float incT5 = 0.1F;
	public float incT6 = 0.1F;

	public float total_tiempo = 0.50F;
	private int torre = 0;

	void Start()
	{
		barraTorre1.size = valorT1;
		barraTorre2.size = valorT2;
		barraTorre3.size = valorT3;
		barraTorre4.size = valorT4;
		barraTorre5.size = valorT5;
		barraTorre6.size = valorT6;

	}

	void lanzar_rayos()
	{
		if (Input.GetKey (KeyCode.Q)) {
			if (valorT1 <= 1) {
				barraTorre1.size += valorT1 += incT1;
				torre = 1;
			}
		} else {
			barraTorre1.size = 0;
			valorT1 = 0;
		}
		if (Input.GetKey (KeyCode.A)) {
			if (valorT2 <= 1) {
				barraTorre2.size += valorT2 += incT2;
				torre = 2;
			}
		} else {
			barraTorre2.size = 0;
			valorT2 = 0;
		}


		if (Input.GetKey (KeyCode.S)) {
			if (valorT3 <= 1) {
				barraTorre3.size += valorT3 += incT3;
				torre = 3;
			}
		} else {
			barraTorre3.size = 0;
			valorT3 = 0;
		}

		if (Input.GetKey (KeyCode.D)) {
			if (valorT4 <= 1) {
				barraTorre4.size += valorT4 += incT4;
				torre = 4;
			}
		} else {
			barraTorre4.size = 0;
			valorT4 = 0;
		}


		if (Input.GetKey (KeyCode.E)) {
			if (valorT5 <= 1) {
				barraTorre5.size += valorT5 += incT5;
				torre = 5;
			}
		} else {
			barraTorre5.size = 0;
			valorT5 = 0;
		}


		if (Input.GetKey (KeyCode.W)) {
			if (valorT6 <= 1) {
				barraTorre6.size += valorT6 += incT6;
				torre = 6;
			}
		} else {
			barraTorre6.size = 0;
			valorT6 = 0;
		}

	}
	void Update()
	{
		if(Time.timeScale != 0)
		{
			lanzar_rayos();
		}




	}
}

