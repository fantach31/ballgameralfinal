using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneController : MonoBehaviour
{
    public void NextScene()
    {
        int currentScene = UnitySceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;

       // if (nextScene > UnitySceneManager.sceneCount)

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(int levelIndex)
    {
        
    }
}
