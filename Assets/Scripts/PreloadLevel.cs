using UnityEngine;
using System.Collections;

public class PreloadLevel : MonoBehaviour {

	//public Animator menuAnim;

	AsyncOperation async;
	bool puedeCargar;

	int indice = 0;


	void Start()
	{
		//StartCoroutine(Preload());
	}

	public void CargarEscena()
	{
		//menuAnim.SetTrigger(trigger);
		puedeCargar = true;
		async.allowSceneActivation = true;
	}

	public void Escena(int index)
	{
		SceneManager.instance.escena = index;
	}


	public void CargarPagina(int index)
	{
		indice = index;
	}


	public void LoadEscena()
	{
		Application.LoadLevel(1);
	}
	IEnumerator Preload()
	{
		async = Application.LoadLevelAsync(1);
		async.allowSceneActivation = false;

		yield return async;
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();

//		if(puedeCargar)
//		{
//			if(async != null && async.isDone)
//			{
//				print ("peo");
//			}
//		}
	}

}
