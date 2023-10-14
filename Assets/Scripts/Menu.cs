using UnityEngine;
using UnityEngine.SceneManagement; // Cambio de escena

public class Menu : MonoBehaviour
{
    #region PantallaDeInicio
    public void ModoHistoria(){
        PlayerPrefs.SetInt("Puntaje", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Infinito(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    #endregion
    
    #region Botones
    public void Siguiente(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    #endregion
    
    public void QuitGame(){
        Application.Quit(); //Solo funciona cuando sale el ejecutable final 
    }

}
