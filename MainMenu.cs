using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Reset();
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Reset();
        SceneManager.LoadScene(0);
    }

    public void RestartLevel()
    {
        Reset();
        SceneManager.LoadScene(1);

    }

    void Reset(){
        GameOverText.gameOver = false;
        HealthManagerPlanet.planetSad = false;
        HealthManagerPlayer.playerHealth = 5;
    }

}
