using UnityEngine;
using System.Collections;

public class Translate : MonoBehaviour {

	public float velocidad;

	void FixedUpdate()
	{

		float v = Mathf.PingPong(Time.time , velocidad * -1);
		transform.Translate(Vector2.right * velocidad * Time.deltaTime * v);
	}

}
