using UnityEngine;
using System.Collections;

public class Escena : MonoBehaviour {

	public enum Transiciones{ Corte, FadeInBlanco, FadeOutBlanco, FadeInNegro, FadeOutNegro}
	public enum ListaCanciones{ intro, arbolSinHojas, esperando, guidoTriste, incendio, devastacion, final};

	public Transiciones transicionEntrada, transicionSalida, transicionVuelta;
	public MusicManager.ListaCanciones cancion;
	public Ayuda.Help ayuda;

	public void ActivarMusica()
	{
		MusicManager.instance.ChequearCancion(cancion);
		MusicManager.instance.reproduciendo = cancion;
		MusicManager.instance.PlayMusic();
	}


	public void CambiarCancion()
	{
		MusicManager.instance.Transicion(cancion);
	}


	void OnEnable()
	{
		Ayuda.tipoAyuda = ayuda;
	}

}
