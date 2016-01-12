using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
    public float timer;
    public string levelToLoad = "MainMenu";
	// Use this for initialization
	void Start () {
        StartCoroutine("DisplayScene");
	}
	
	// Update is called once per frame
	IEnumerator DisplayScene() {
        yield return new WaitForSeconds(timer);
        Application.LoadLevel(levelToLoad);
	}
}
