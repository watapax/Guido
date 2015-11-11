using UnityEngine;
using System.Collections;

public class PreloadLevel : MonoBehaviour {

	//public Animator menuAnim;

	AsyncOperation async;
	bool puedeCargar;

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


	public void LoadEscena(int index)
	{
		Application.LoadLevel(index);
	}
	IEnumerator Preload()
	{
		async = Application.LoadLevelAsync(1);
		async.allowSceneActivation = false;

		yield return async;
	}

//	void Update()
//	{
//		if(Input.GetKeyDown(KeyCode.Escape))
//			Application.Quit();
//
//		if(puedeCargar)
//		{
//			if(async != null && async.isDone)
//			{
//				print ("peo");
//			}
//		}
//	}

}
