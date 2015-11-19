using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public static SceneManager instance;

	[HideInInspector] public int escena;

	
	void Awake()
	{
		DontDestroyOnLoad(this);
		
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
	}


	public void Escena(int index)
	{
		escena = index;
	}



	public void CargarEscena(int indice)
	{
		Application.LoadLevel(indice);
	}

}
