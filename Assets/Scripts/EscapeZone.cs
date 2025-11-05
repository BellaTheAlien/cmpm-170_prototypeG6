using UnityEngine;
using UnityEngine.UI;

public class EscapeZone : MonoBehaviour
{
    [SerializeField] private GameObject youWinPanel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (KeyPickUp.hasKey)
            {
                Debug.Log("You Win!");
                youWinPanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                Debug.Log("You need a key to escape!");
            }
        }
    }
}
