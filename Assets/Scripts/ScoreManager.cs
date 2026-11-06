using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int Score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateScoreUi()
    { 
        if (Score < 1)
        {
            scoreText.text = "Score : 0";
        }
        else
        {
            scoreText.text = "Score : " + Score.ToString();
        }
    }
    public void addScore(int amount) 
    {
         Score += amount;
         UpdateScoreUi();
         Debug.Log($"+ {amount} Score");
    }

      public void removeScore(int amount) 
    {
         Score -= amount;
         UpdateScoreUi();
         Debug.Log($"- {amount} Score");
    }

}
