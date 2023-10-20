using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public bool infinito = false;
    
    
    void Awake()
    {
        SetScoreText(PlayerPrefs.GetInt("Puntaje"));
    }

    public void SetScoreText(int currentScore){
        if(infinito){
            scoreText.text = "Puntaje: " + currentScore.ToString();
        }else{
            scoreText.text = "Puntaje: " + currentScore.ToString() + "/" + PlayerPrefs.GetInt("WinScore").ToString();
        }
        
    }

}
