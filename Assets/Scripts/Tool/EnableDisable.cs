using UnityEngine;
using System.Collections;

public class EnableDisable : MonoBehaviour {


	public GameObject objeto;

	void OnEnable()
	{
		objeto.SetActive(true);
	}

}
