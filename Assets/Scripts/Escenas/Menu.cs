using UnityEngine;
using UnityEngine.SceneManagement; // Cambio de escena

public class Menu : MonoBehaviour
{
    private int winScore = 10;


    #region PantallaDeInicio
    public void ModoHistoria(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Infinito(){
        //SceneManager.LoadScene("19_puntajeFinal");
        SceneManager.LoadScene("18_infinito");
    }
    #endregion
    
    #region Botones

    public void Siguiente(){
        PlayerPrefs.SetInt("WinScore", winScore);
        PlayerPrefs.SetInt("Puntaje", 0);
        //PlayerPrefs.SetInt("Arrastrando", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Repetir(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion
    
    public void QuitGame(){
        Application.Quit(); //Solo funciona cuando sale el ejecutable final 
    }

}
