using UnityEngine;

public class ParteSommerfeld : MonoBehaviour
{
    public Base ObjetoBase;
    public bool excepcion = false;
    private int enOrbita1 = 0;
    private int enOrbita2 = 0;
    private int enOrbita3 = 0;/*
    private bool orbita1LLena = false;
    private bool orbita2LLena = false;
    private bool orbita3LLena = false;*/

    private void OnTriggerEnter(Collider other)
    {
        // Para evitar electrones amontonados
        if(other.CompareTag("Parte") && !excepcion){ 
            ObjetoBase.ObjetoFueraDeRango();
        }
        
        // Para los neutrones (blancos)
        if(excepcion && other.CompareTag("Rango1")){
            ObjetoBase.ObjetoEnContacto();
        }

        // Para los electrones (azules - órbita 1)
        if(other.CompareTag("Rango2") && !excepcion && (enOrbita1 < 3)){
            if(enOrbita2 >= 2){
                ObjetoBase.ObjetoFueraDeRango();
            }
            ObjetoBase.ObjetoEnContacto();
            enOrbita1 ++;
            enOrbita2 --;
        }

        // Para los electrones (azules - órbita 2)
        if(other.CompareTag("Rango3") && !excepcion && (enOrbita2 < 2)){
            if(enOrbita3 >= 1){
                ObjetoBase.ObjetoFueraDeRango();
            }
            ObjetoBase.ObjetoEnContacto();
            enOrbita2 ++;
            enOrbita3 --;
        }

        // Para los electrones (azules - órbita 3)
        if(other.CompareTag("Rango4") && !excepcion){ 
            if(enOrbita3 < 1){
                ObjetoBase.ObjetoEnContacto();
            }
            enOrbita3 ++;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        // Para evitar electrones amontonados
        if(other.CompareTag("Parte") && !excepcion){ 
            ObjetoBase.ObjetoEnContacto();
        }
        
        // Para los neutrones (blancos)
        if(excepcion && other.CompareTag("Rango1")){
            ObjetoBase.ObjetoFueraDeRango();
        }

        // Para los electrones (azules - órbita 1)
        if(other.CompareTag("Rango2") && !excepcion){
            ObjetoBase.ObjetoFueraDeRango();
            enOrbita1 --;
            if(enOrbita2 < 2){
                ObjetoBase.ObjetoEnContacto();
            }
            enOrbita2 ++;
        }

        // Para los electrones (azules - órbita 2)
        if(other.CompareTag("Rango3") && !excepcion){
            ObjetoBase.ObjetoFueraDeRango();
            enOrbita2 --;
            if(enOrbita3 < 1){
                ObjetoBase.ObjetoEnContacto();
            }
            enOrbita3 ++;
        }

        // Para los electrones (azules - órbita 3)
        if(other.CompareTag("Rango4") && !excepcion){ 
            ObjetoBase.ObjetoFueraDeRango();
            enOrbita3 --;
        }
    }
}

