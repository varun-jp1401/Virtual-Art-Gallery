using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Function to load the art gallery scene
    public void LoadArtGallery()
    {
        SceneManager.LoadScene("Art gallery"); // Change this to your actual gallery scene name
    }
}
