using UnityEngine;
using System.Collections;


public class BotVision : MonoBehaviour
{
    public GameObject redOverlay; // Assign in inspector
    public GameObject detectionText;
    public GameObject lossPanel;

    private bool playerInside = false;
    private Coroutine detectionCoroutine;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected!");
            redOverlay.SetActive(true);
            detectionText.SetActive(true);
            playerInside = true;

            detectionCoroutine = StartCoroutine(LoseAfterDelay(0.5f));
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player escaped in time!");
            redOverlay.SetActive(false);
            detectionText.SetActive(false);
            playerInside = false;

            if (detectionCoroutine != null)
                StopCoroutine(detectionCoroutine);
        }
    }


    private IEnumerator LoseAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (playerInside)
        {
            Debug.Log("Player lost!");
            lossPanel.SetActive(true);
            Time.timeScale = 0f; // optional: freeze game
        }
    }

}