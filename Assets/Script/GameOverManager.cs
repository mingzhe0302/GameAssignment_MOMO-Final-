using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject youLosePanel; // ?? "You Lose" ??? GameObject
    public string playerTag = "Player"; // ?????

    private void Start()
    {
        // ?? "You Lose" ??
        youLosePanel.SetActive(false);
    }

    private void Update()
    {
        // ??????????
        GameObject[] players = GameObject.FindGameObjectsWithTag(playerTag);

        if (players.Length == 0)
        {
            ShowYouLosePanel();
        }
    }

    private void ShowYouLosePanel()
    {
        // ?? "You Lose" ??
        youLosePanel.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        // ?? "You Lose" ??
        youLosePanel.SetActive(false);

        // ????
        Time.timeScale = 1f;
    }
}
