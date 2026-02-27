using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Szene per Name laden
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Szene per Build Index laden
    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    // Beispiel: nächste Szene
    public void LoadNextScene()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }
}
