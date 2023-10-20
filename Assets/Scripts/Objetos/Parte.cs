using UnityEngine;

public class Parte : MonoBehaviour
{
    public Base ObjetoBase;
    public bool excepcion = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Parte") && !excepcion){ // Compara con el objeto llamado "Parte".
            ObjetoBase.ObjetoFueraDeRango();
        }

        if(!other.CompareTag("Rango1") && other.CompareTag("Rango2") && !excepcion){ // Para los límites Rango1 es el interior y Rango2 es el exterior
            ObjetoBase.ObjetoEnContacto();
        }else if(excepcion && other.CompareTag("Rango1")){
            ObjetoBase.ObjetoEnContacto();
        }

        if(other.CompareTag("Rango1") && !excepcion){
            ObjetoBase.ObjetoFueraDeRango();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Parte") && !excepcion){
            ObjetoBase.ObjetoEnContacto();
        }

        if(!other.CompareTag("Rango1") && other.CompareTag("Rango2") && !excepcion){ 
            ObjetoBase.ObjetoFueraDeRango();
        }else if(excepcion && other.CompareTag("Rango1")){
            ObjetoBase.ObjetoFueraDeRango();
        }

        if(other.CompareTag("Rango1") && !excepcion){
            ObjetoBase.ObjetoEnContacto();
        }
    }

}

