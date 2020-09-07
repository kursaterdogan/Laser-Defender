using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float waitDuration = 1f;
    GameSession gameSession;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        gameSession = FindObjectOfType<GameSession>();
        if (gameSession)
            gameSession.ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());

    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(waitDuration);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
