using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Propriedades
    public float posX;
    public float posYMin;
    public float posYMax;

    public Inimigo empada;
  
    float tempo = 5.0f;


    public void Start()
    {


    }
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

    //Metodos
    public void CriarNaveInimiga()
    {
        float posAleatoriaInimigo = Random.Range(posYMin, posYMax);
        Vector3 vetor3Aleatorio = new Vector3(posX, posAleatoriaInimigo, 0.0f);
        Instantiate(empada, vetor3Aleatorio, Quaternion.identity);
    }
}