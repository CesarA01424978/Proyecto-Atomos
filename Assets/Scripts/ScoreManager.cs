using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int winScore = 10;
    
    
    void Awake()
    {
        PlayerPrefs.SetInt("WinScore", winScore);
        SetScoreText(PlayerPrefs.GetInt("Puntaje"));
    }

    public void SetScoreText(int currentScore){
        scoreText.text = "Puntaje: " + currentScore.ToString() + "/" + winScore.ToString();
    }

}
