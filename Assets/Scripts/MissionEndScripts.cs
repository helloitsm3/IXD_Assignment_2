using UnityEngine;
using System.Collections;

public class MissionEndScripts : MonoBehaviour {

	public void MainMenu()
    {
        Application.LoadLevel(1);
    }

    public void ShopPage()
    {
        Application.LoadLevel(5);
    }

    public void RestartGame()
    {
        Application.LoadLevel(6);
    }

    public void NextGame()
    {
        Application.LoadLevel(16);
    }
}
