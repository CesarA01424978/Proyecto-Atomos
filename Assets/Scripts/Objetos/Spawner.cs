using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] atomos;
    private int cantidadDeAtomos = 15;

    void Start(){
        if(atomos[0] != null){
            for(int i = 0; i < cantidadDeAtomos; i++){
                AparecerAtomo();
            }
        }else{
            #if UNITY_EDITOR
            Debug.LogError("No tiene átomos asignados");
            #endif
        }
    }

    void Update(){

        if(PlayerPrefs.GetFloat("EnEscena") == 0){
            AparecerAtomo();
            PlayerPrefs.SetFloat("EnEscena", 1);
        }
        
    }

    void AparecerAtomo(){
        //Posicion
        float randomComplemento = (Random.Range(1f, 9f))/10f;
        float randomXPosition = (Random.Range(-9f, 10f)) + randomComplemento;
        float randomYPosition = (Random.Range(8f, 16f)) + randomComplemento;
        Vector3 spawnPosition = new Vector3(randomXPosition, randomYPosition, 0f);
        //instanciar
        Instantiate(atomos[GetRandomAtomos()], spawnPosition, transform.rotation);//Array
    }

    int GetRandomAtomos(){
        int randomAtomo = Random.Range(0, atomos.Length);
        return randomAtomo;
    }

}
