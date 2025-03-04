using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gamehasended = false;
    public float RestartDelay= 1f;

    public GameObject completelevelUI;
    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }

    public void Endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over!");
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
