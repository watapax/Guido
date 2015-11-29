using UnityEngine;
using System.Collections;

public class SeleccionarIdioma : MonoBehaviour {



	public static SeleccionarIdioma instance;

	[Header("Idiomas")]
	public TextAsset español;
	public TextAsset ingles;
	public TextAsset portugues;
	public TextAsset japones;

	[Header("Menu")]
	public TextAsset menuEspañol;
	public TextAsset menuIngles;
	public TextAsset menuPortugues;
	public TextAsset menuJapones;

	public enum TipoTexto{textoMenu, textoCuento};
	
	string[] txtEspañol, txtIngles, txtJapones, txtPortugues;
	string[] txtEspañolMenu, txInglesMenu, txtJaponestMenu, txtPortuguesMenu;

	[HideInInspector] public string[] idiomaFinal;
	[HideInInspector] public string[] menuIdiomaFinal;

	void Awake()
	{
		if(instance != null)
		{
			if(instance != this)
				Destroy(gameObject);
		}
		else
			instance = this;


		DontDestroyOnLoad(this);

		CargarTextos();
		ElejirIdioma(0); // idioma por defecto es español


	}



	void CargarTextos()
	{
		txtEspañol = español.text.Split('\n');
		txtIngles = ingles.text.Split('\n');
		txtJapones = japones.text.Split('\n');
		txtPortugues = portugues.text.Split('\n');


		txtEspañolMenu = menuEspañol.text.Split('\n');
		txInglesMenu = menuIngles.text.Split('\n');
		txtJaponestMenu = menuJapones.text.Split('\n');
		txtPortuguesMenu = menuPortugues.text.Split('\n');
	}



	public void ElejirIdioma(int idioma)
	{
		CargarTextos();
		switch(idioma)
		{
		case 0:
			idiomaFinal = txtEspañol;
			menuIdiomaFinal = txtEspañolMenu;
			break;
		case 1:
			idiomaFinal = txtIngles;
			menuIdiomaFinal = txInglesMenu;
			break;
		case 2:
			idiomaFinal = txtJapones;
			menuIdiomaFinal = txtJaponestMenu;
			break;
		case 3:
			idiomaFinal = txtPortugues;
			menuIdiomaFinal = txtPortuguesMenu;
			break;
		}
	}




}
