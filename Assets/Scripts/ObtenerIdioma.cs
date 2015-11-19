using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObtenerIdioma : MonoBehaviour {


	public int indiceTexto;
	Text texto;
	SeleccionarIdioma idioma;


	public SeleccionarIdioma.TipoTexto tipoDeTexto;

	void Start()
	{
		idioma = (SeleccionarIdioma) FindObjectOfType(typeof(SeleccionarIdioma));
		texto = GetComponent<Text>();
	}

	void Update()
	{
		//if(SeleccionarIdioma.instance != null)
		//texto.text = SeleccionarIdioma.instance.idiomaFinal[indiceTexto];
		if(tipoDeTexto == SeleccionarIdioma.TipoTexto.textoMenu)
			texto.text = idioma.menuIdiomaFinal[indiceTexto];
		else if(tipoDeTexto == SeleccionarIdioma.TipoTexto.textoCuento)
			texto.text = idioma.idiomaFinal[indiceTexto];
	}

}
