using UnityEngine;
using System.Collections;

public class Ayuda : MonoBehaviour {

	public enum Help{nada, touch, drag, agitar, girar}
	public GameObject touch, drag, girar, agitar;

	public static Help tipoAyuda;
	Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();
		touch.SetActive(false);
		drag.SetActive(false);
		girar.SetActive(false);
		agitar.SetActive(false);
	}

	public void Activar()
	{
		if(tipoAyuda == Help.nada)return;
		else
			anim.SetTrigger("in");
	}

	public void ActivarAyuda()
	{
		switch(tipoAyuda)
		{
		case Help.nada:
			return;
			break;
		case Help.touch:

			touch.SetActive(true);
			break;
		case Help.drag:

			drag.SetActive(true);
			break;
		case Help.agitar:

			agitar.SetActive(true);
			break;
		case Help.girar:

			girar.SetActive(true);
			break;
		}
	}


}
