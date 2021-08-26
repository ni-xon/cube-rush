using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsRunning = true;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void GameOver ()
    {
        if (gameIsRunning == true)
        {
            gameIsRunning = false;
            Debug.Log("GAME OVER");
            // Invoke will wait x seconds and then execute the function
            Invoke("RestartGame", restartDelay);

        }
        
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
