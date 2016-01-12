using UnityEngine;
using System.Collections;

public class ButtonInteraction : MonoBehaviour {

    public GameObject loadingImage;

    public void loadScene(int buttons)
    {
        loadingImage.SetActive(true);
        Application.LoadLevel(buttons); 
    }

    public void endGame()
    {
        Application.Quit();
    }
}
