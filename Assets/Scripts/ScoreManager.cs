using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    
    void Awake()
    {
        SetScoreText(PlayerPrefs.GetInt("Puntaje"));
    }

    public void SetScoreText(int currentScore){
        scoreText.text = "Puntaje: " + currentScore.ToString() + "/" + PlayerPrefs.GetInt("WinScore").ToString();
    }

}
