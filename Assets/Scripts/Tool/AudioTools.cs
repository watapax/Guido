using UnityEngine;
using System.Collections;

public class AudioTools : MonoBehaviour {

	AudioSource audioSource;

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Start()
	{
		if(!SceneManager.instance.firstTimeApp)
			audioSource.Play();
	}
	public void ToggleMute()
	{
		audioSource.ToggleMutedAudio();
	}

}
