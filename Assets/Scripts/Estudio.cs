using System.Collections; //Para la corrutina
using UnityEngine;
using UnityEngine.SceneManagement; // Cambio de escena

public class Estudio : MonoBehaviour
{
    private float tiempo = 16f;
    
    void Start()
    {
        StartCoroutine(CambiarEscena());
    }

    private IEnumerator CambiarEscena(){
        yield return new WaitForSecondsRealtime(tiempo); //Tiempo para esperar 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StopAllCoroutines();
    }
}
