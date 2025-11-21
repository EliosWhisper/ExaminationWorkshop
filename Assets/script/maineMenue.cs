using UnityEngine;
using UnityEngine.SceneManagement;

public class maineMenue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("PlayGame");
    }
}
