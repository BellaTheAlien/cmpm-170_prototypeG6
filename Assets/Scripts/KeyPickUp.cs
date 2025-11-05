using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public static bool hasKey = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;
            Debug.Log("Key collected!");

            // Destroy the key object after collecting it
            Destroy(gameObject);
        }
    }
}
