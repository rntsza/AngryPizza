using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : GameController
{
    //Propriedades
    public int vida = 2;
    //int dano = 1;
    //float dropRate = 0.20f;
    public int alvosMortos = 0;
    public float velocidade;

    //TODO (A fazer)
    //Criar uma velocidade aleatória!!

    //Componente
    Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.left * velocidade);
    }

    private void OnCollisionEnter2D(Collision2D tiros)
    {
        if (tiros.gameObject.CompareTag("tiros"))
        {
            vida--;
            Debug.Log("Vida" + vida);
            Destroy(tiros.gameObject);
            if (vida == 0)
            {
                Destroy(this.gameObject);
                alvosMortos++;
                Debug.Log("Alvo morto" + alvosMortos);
            }
        }
    }

    public void DroparItem()
    {
        //TODO (A fazer)
    }

    /*public void dificuldade()
    {
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
        }
    }*/
}