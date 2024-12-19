using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryController : MonoBehaviour
{
    void Update()
    {
        // Check if the ESC key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene"); // Change this to your actual menu scene name
        }
    }
}
