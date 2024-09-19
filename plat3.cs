using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add to player's score or crystals collected
            Destroy(gameObject);
        }
    }
}
