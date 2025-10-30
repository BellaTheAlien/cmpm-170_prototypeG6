using UnityEngine;

public class BotVision : MonoBehaviour
{
    public GameObject redOverlay; // Assign in inspector
    public GameObject detectionText;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected!");
            redOverlay.SetActive(true);
            detectionText.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            redOverlay.SetActive(false);
            detectionText.SetActive(false);
        }
    }
}