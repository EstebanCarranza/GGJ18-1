using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasScript : MonoBehaviour {
	public static canvasScript ins;
	public Astronauta astro,Astro;

	void Awake()
	{
		ins = this;
	}

	public void spawnAstronauta()
	{
		Astro = Instantiate(astro) as Astronauta;
		Astro.transform.SetParent (transform, false);
		Astro.transform.position = ins.transform.position;
	}

	public void dessapearAstronauta() 
	{
		Destroy (transform.gameObject);
	}

}

