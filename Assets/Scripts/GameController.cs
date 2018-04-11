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
    
    public AudioSource scene1;
    bool mplay, mplaychange;


    public void Start()
    {
        scene1 = GetComponent<AudioSource>();
        mplay = true;
    }
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo < 0)
        {
            CriarNaveInimiga();
            tempo = 5.0f;
        }

        // Opções de BGM
        if (mplay == true && mplaychange == true)
        {
            scene1.Play();
            mplaychange = false;
        }
        if (mplay == false && mplaychange == true)
        {
            scene1.Stop();
            mplaychange = false;
        }
    }
    void OnGUI()
    {
        mplay = GUI.Toggle(new Rect(10, 10, 100, 30), mplay, "Play Music");

        if (GUI.changed)
        {
            mplaychange = true;
        }
    }
    public void CriarNaveInimiga()
    {
        float posAleatoriaInimigo = Random.Range(posYMin, posYMax);
        Vector3 vetor3Aleatorio = new Vector3(posX, posAleatoriaInimigo, 0.0f);
        Instantiate(empada, vetor3Aleatorio, Quaternion.identity);
    }
}