using UnityEngine;

public class Atomo : MonoBehaviour
{
    private float limiteInferior = -4f;
    public int _score = 1;
    private Vector3 vectorFinal = new Vector3(0, -4f, 0);
    private bool repitio;

    private void Update()
    {
        if(transform.position.y > limiteInferior){
            transform.Translate(vectorFinal * 1f * Time.deltaTime);
        }else if (!repitio){
            //Posicion nueva
            float randomComplemento = (Random.Range(1f, 9f))/10f;
            float randomXPosition = (Random.Range(-9f, 10f)) + randomComplemento + randomComplemento/10;
            float randomYPosition = (Random.Range(8f, 16f));
            Vector3 vectorInicial = new Vector3(randomXPosition, randomYPosition, 0f);
            transform.position = vectorInicial;
            repitio = true;
        }else{
            Destroy(gameObject);
            PlayerPrefs.SetFloat("EnEscena", 0);
        }
    }

    private void OnMouseDown(){
        GameManager.instance.UpdateScore(_score);
        Destroy(gameObject);
        PlayerPrefs.SetFloat("EnEscena", 0);
    }

}
