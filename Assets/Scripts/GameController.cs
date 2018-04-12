using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Propriedades
    public float posX = 17.0f;
    public float posYMin = -3.33f;
    public float posYMax = 3.33f;

    public Inimigo impada;
    //public GameObject empada;
    float tempo = 5.0f;


    /*public void Start()
    {


    }*/
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo < 0)
        {
            CriarNaveInimiga();
            tempo = 5.0f;
        }
    }

    
    //TODO (A fazer)
    //Fazer nascer a cada x tempo
    public void dificuldade()
    {
        //ToDo

        /*
        if (alvosMortos >= 3)
        {
            base.timer = 2.0f;
        }
        else if (alvosMortos >= 4)
        {
            base.timer = 1.0f;
        }
        else if (alvosMortos > 5)
        {
            base.timer = 0.5f;
        }
        else
        {
            base.timer = 5.0f;
        }*/
    }


    //Metodos
    public void CriarNaveInimiga()
    {
        float posAleatoriaInimigo = Random.Range(posYMin, posYMax);
        Vector3 vetor3Aleatorio = new Vector3(posX, posAleatoriaInimigo, 0.0f);
        Instantiate(impada, vetor3Aleatorio, Quaternion.identity);
    }
}