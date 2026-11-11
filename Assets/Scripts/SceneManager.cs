using UnityEngine;
using UnityEngine.SceneManagement;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    [SerializeField] private int requiredScore = 30;

    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager player = other.GetComponent<ScoreManager>();
            if (player != null) {
                if (player.Score >= requiredScore)
                {
                    NextLevel();
                }
                else
                {
                    print($"Baþarýsýz. Gereken puan: {requiredScore} ");
                }
            }
        }

    }
    private void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;

        if (nextScene < SceneManager.sceneCountInBuildSettings)
        {
            print($"Seviye {currentScene} baþarýyla geçildi!");
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            print("Oyunu kazandýn!");
        }
    }
    void Update()
    {
  
    }
}
