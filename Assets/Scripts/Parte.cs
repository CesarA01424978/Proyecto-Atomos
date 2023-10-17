using UnityEngine;

public class Parte : MonoBehaviour
{
    private bool encimados = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Parte")){
            encimados = true;
        }

        if (other.CompareTag("Base") && !encimados){ // Compara con el objeto llamado "Base".
            Base baseScript = other.GetComponent<Base>();
            if (baseScript != null){
                baseScript.ObjetoEnContacto();
            }
        }else{
            Base baseScript = other.GetComponent<Base>();
            if (baseScript != null){
                baseScript.ObjetoFueraDeRango();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Parte")){
            encimados = false;
        }

        if (other.CompareTag("Base")){ // Compara con el objeto llamado "Base".
            Base baseScript = other.GetComponent<Base>();
            if (baseScript != null){
                baseScript.ObjetoFueraDeRango();
            }
        }
    }

}

