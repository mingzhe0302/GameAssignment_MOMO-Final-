using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject youWinPanel; // ?? "You Win" ??? GameObject
    public string enemyTag = "Enemy"; // ?????

    private void Start()
    {
        // ?? "You Win" ??
        youWinPanel.SetActive(false);
    }

    private void Update()
    {
        // ??????????
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        if (enemies.Length == 0)
        {
            ShowYouWinPanel();
        }
    }

    private void ShowYouWinPanel()
    {
        // ?? "You Win" ??
        youWinPanel.SetActive(true);
    }
}
