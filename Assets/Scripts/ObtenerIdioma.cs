using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObtenerIdioma : MonoBehaviour {


	public int indiceTexto;
	Text texto;
	SeleccionarIdioma idioma;

	void Start()
	{
		idioma = (SeleccionarIdioma) FindObjectOfType(typeof(SeleccionarIdioma));
		texto = GetComponent<Text>();
	}

	void Update()
	{
		//if(SeleccionarIdioma.instance != null)
		//texto.text = SeleccionarIdioma.instance.idiomaFinal[indiceTexto];
		texto.text = idioma.idiomaFinal[indiceTexto];
	}

}
