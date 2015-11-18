using UnityEngine;
using System.Collections;

public class MoverConViento : MonoBehaviour {

	float randomSpeed;
	[HideInInspector] public Transform t;


	void Awake()
	{
		randomSpeed = Random.Range(0.05f , 0.035f);

		t = GetComponentInChildren<SpriteRenderer>().gameObject.transform.parent;
		Vector2 screenPos = Camera.main.WorldToScreenPoint( GetComponentInChildren<SpriteRenderer>().gameObject.transform.position) * -1;
		GetComponentInChildren<SpriteRenderer>().sortingOrder = (int)screenPos.y;


	}

	void FixedUpdate()
	{
		float fuerza = MicrophoneInput.instance.ruido * randomSpeed;
		if(fuerza > 0.01) t.localPosition = new Vector3(t.localPosition.x , t.localPosition.y + fuerza , 0);
	}

	void OnDisable()
	{
		// resetear posicion hoja
		t.localPosition = Vector3.zero;
	}

}
