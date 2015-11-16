using UnityEngine;
using System.Collections;

public class AudioTools : MonoBehaviour {

	AudioSource audioSource;

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void ToggleMute()
	{
		audioSource.ToggleMutedAudio();
	}

}
