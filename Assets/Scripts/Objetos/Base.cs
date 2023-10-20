using UnityEngine;
using UnityEngine.SceneManagement; // Cambio de escena

public class Base : MonoBehaviour
{
    // Número de objetos necesarios para cambiar de escena.
    public int objetosRequeridos = 5;

    // Lleva un conteo de los objetos que han entrado en contacto.
    private int objetosEnContacto = 0;

    // Para ver si está en el plano
    private bool enPlano = false;

    // Método para aumentar el conteo de objetos en contacto.
    public void ObjetoEnContacto()
    {
        objetosEnContacto++;
        Debug.Log(objetosEnContacto);

        if ((objetosEnContacto >= objetosRequeridos) && enPlano )
        {
            //Debug.Log("Cambió");
            CambiarEscena();
        }
    }

    public void ObjetoFueraDeRango()
    {
        objetosEnContacto--;
        //Debug.Log(objetosEnContacto);
    }

    // Método para cambiar a una nueva escena.
    private void CambiarEscena()
    {
        Debug.Log("Acabó");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plano")){ // Compara con el objeto llamado "Plano".
            enPlano = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plano")){ // Compara con el objeto llamado "Plano".
            enPlano = false;
        }
    }
}