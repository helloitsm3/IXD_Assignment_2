using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

    public AudioClip level1Music;

    private AudioSource source;

	// Use this for initialization
	void changeMusic () {
        source = GetComponent<AudioSource>();
	}

    void levelWasLoaded(int level)
    {
        if(level == 2)
        {
            source.clip = level1Music;
            source.Play();
        }
    }
}
