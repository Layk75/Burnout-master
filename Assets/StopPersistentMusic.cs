using UnityEngine;

public class StopPersistentMusic : MonoBehaviour
{
    void Start()
    {
        // Find the persistent music object and stop the music
        PersistentMusic persistentMusic = FindObjectOfType<PersistentMusic>();
        if (persistentMusic != null)
        {
            persistentMusic.StopMusic(); // Stop the music from the previous scenes
            Destroy(persistentMusic.gameObject); // Optionally, destroy the object to free memory
        }

        // Play the new music (assuming there's an AudioSource on this object)
        AudioSource newMusic = GetComponent<AudioSource>();
        if (newMusic != null)
        {
            newMusic.Play();
        }
    }
}
