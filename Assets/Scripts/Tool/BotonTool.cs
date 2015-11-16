using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotonTool : MonoBehaviour {

	Text textoBoton;
	Image imagen;
	bool toggle;


	void Awake()
	{
		textoBoton = GetComponentInChildren<Text>();
		imagen = GetComponent<Image>();
	}

	public void ToggleAudio()
	{
		toggle = !toggle;
		if(toggle)
			textoBoton.text = "Musica On";
		else
			textoBoton.text = "Musica Off";
	}

	public void OpenUrl(string url)
	{
		Application.OpenURL(url);
	}

}
