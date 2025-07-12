using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI; 

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (CompareTag("Player") && other.CompareTag("Enemy"))
        {
            TriggerGameOver();
        }

        
        if (other.CompareTag("Enemy") && !CompareTag("Enemy"))
        {
            TriggerGameOver();
        }

        
    }

    void TriggerGameOver()
    {
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        Time.timeScale = 0f; 
    }
}