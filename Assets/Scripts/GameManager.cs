using UnityEngine;
using UnityEngine.SceneManagement; // Cambio de escena

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public static GameManager instance;
    private int winScore;
    private int totalScore;

    private void Awake(){
        //Para llevarse los datos a otras escenas
        /*if(instance!=null && instance!=this){
            Destroy(gameObject);
        }else{*/
            instance = this;
            /*DontDestroyOnLoad(gameObject);
        }*/

        winScore = PlayerPrefs.GetInt("WinScore");
        totalScore = PlayerPrefs.GetInt("Puntaje");
    }

    #region Score
    public void UpdateScore(int addScore){
        totalScore += addScore;
        scoreManager.SetScoreText(totalScore);

        if(totalScore >= winScore){
            PlayerPrefs.SetInt("Puntaje", totalScore);
            SceneManager.LoadScene("Level0");
        }
    }
    #endregion

    void Update(){
        //PlayerPrefs.SetInt("Puntaje", totalScore);
        if(Input.GetKey("w")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void QuitGame(){
        Application.Quit(); //Solo funciona cuando sale el ejecutable final 
    }
}
