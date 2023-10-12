using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] atomos;
    //public int cantidadDeAtomos = 10;

    void Start(){
        if(atomos[0] != null){
            for(int i = 0; i < 10; i++){
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
        float randomComplemento = (Random.Range(1, 9))/10;
        float randomXPosition = (Random.Range(-9, 10)) + randomComplemento;
        float randomYPosition = (Random.Range(8, 16)) + randomComplemento;
        Vector3 spawnPosition = new Vector3(randomXPosition, randomYPosition, 0f);
        //instanciar
        Instantiate(atomos[GetRandomAtomos()], spawnPosition, transform.rotation);//Array
    }

    int GetRandomAtomos(){
        int randomAtomo = Random.Range(0, atomos.Length);
        return randomAtomo;
    }

}
