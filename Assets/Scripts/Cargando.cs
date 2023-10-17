using UnityEngine;
using TMPro;

public class Cargando : MonoBehaviour
{
    public TextMeshProUGUI textoCargando;
    private float puntito = 0f;
    public GameObject pantalla;

    void Start()
    {
        textoCargando.text = "Cargando...";
    }

    void Update()
    {
        if(puntito < 1){
            textoCargando.text = "Cargando";
            puntito += 0.1f;
        }else if(puntito < 2){
            textoCargando.text = "Cargando.";
            puntito += 0.1f;
        }else if(puntito < 3){
            textoCargando.text = "Cargando..";
            puntito += 0.1f;
        }else if(puntito < 4){
            textoCargando.text = "Cargando...";
            puntito += 0.1f;
        }else{
            puntito = 0f;
        }

        if(Input.GetKey("q")){
            pantalla.SetActive(false);
        }
    }
}
