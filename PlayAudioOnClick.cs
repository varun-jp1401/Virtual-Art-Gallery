using UnityEngine;

public class PlayAudioOnClick : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the painting
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        // Play the audio when the painting is clicked
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
