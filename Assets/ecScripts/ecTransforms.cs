using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ecCode;

public class ecTransforms : MonoBehaviour {


	public float x, y, z;
	public float speed;
	public ecTypeTransform tipoTransformacion;
	public bool activar = true;


	public void translateX()
	{
		transform.position = new Vector3 (transform.position.x + x, transform.position.y, transform.position.z);

	}
	public void translateY()
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y+ y, transform.position.z);

	}
	public void translateZ()
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + z);
	}
	public void translateXY()
	{
		transform.position = new Vector3 (transform.position.x + x, transform.position.y + y, transform.position.z);

	}
	public void translateXYZ()
	{
		transform.position = new Vector3 (transform.position.x + x, transform.position.y + y, transform.position.z + z);

	}
	void rotacion()
	{
		transform.Rotate(Vector3.forward, speed * Time.deltaTime);
	}

	void Start()
	{

	}
	void Update()
	{	
		if (activar) {
			switch (tipoTransformacion) 
			{
			case ecTypeTransform.translatex:
				translateX ();
				break;
			case ecTypeTransform.translatey:
				translateY ();
				break;
			case ecTypeTransform.translatez:
				translateZ ();
				break;
			case ecTypeTransform.translatexy:
				translateXY();
				break;

			case ecTypeTransform.translatexyz:
				translateXYZ ();
				break;

			case ecTypeTransform.rotacion:
				rotacion ();
				break;

			}
		}
	}
}
