using UnityEngine;
using System.Collections;

public class Ayuda : MonoBehaviour {

	public enum Help{nada, touch, drag, agitar, girar}
	public GameObject touch, drag, girar, agitar;

	public Help tipoAyuda;


	[HideInInspector] public GameObject ayudaObject;
	Animator anim;


	void Awake()
	{
		touch.SetActive(false);
		drag.SetActive(false);
		girar.SetActive(false);
		agitar.SetActive(false);



		anim = GetComponent<Animator>();
	}

	public void Activar()
	{
		if(ayudaObject != null)
			anim.SetTrigger("in");
		else
			return;

	}

	public void ActivarAyuda()
	{
		print ("peo");
		ayudaObject.SetActive(true);
	}


}
