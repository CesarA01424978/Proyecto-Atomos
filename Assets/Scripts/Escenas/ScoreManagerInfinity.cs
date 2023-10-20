using UnityEngine;
using TMPro;

public class ScoreManagerInfinity : MonoBehaviour
{
    public TextMeshProUGUI scoreTextInfinity;

    void Awake()
    {
        if((PlayerPrefs.GetInt("Max_Puntaje") < 0)){
            PlayerPrefs.SetInt("Max_Puntaje", 0);
        }
    }

    public void SetScoreText(int actualScore){

        scoreTextInfinity.text = "Puntaje actual: " + actualScore.ToString();
        
        if(actualScore > PlayerPrefs.GetInt("Max_Puntaje")){
            PlayerPrefs.SetInt("Max_Puntaje", actualScore);
        }

    }

}
