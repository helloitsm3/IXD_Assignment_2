using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighscoreScript : MonoBehaviour {
    private int Score;

    public static HighscoreScript currentHighscore;

    Text highscoreLabel;

    void Awake()
    {
        currentHighscore = this;
    }

    // Use this for initialization
    void Start () {
        highscoreLabel = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        highscoreLabel.text = "Score: " + Score;
	}

    public void SetScore(int Score)
    {
        this.Score = Score;
    }

    public int GetScore()
    {
        return Score;
    }
}
