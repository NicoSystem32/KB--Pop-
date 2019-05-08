using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTank : MonoBehaviour
{
    public float velocidad;
    public float distancia;
    private float contador;
    private float posInici;

    //private float posicionActual;
    //private float posicionUltima;

    void Start()
    {
        posInici = transform.position.x;
    }


    void Update()
    {
        contador += Time.deltaTime * velocidad;
        transform.position = new Vector2(Mathf.PingPong(contador, distancia) + posInici, transform.position.y);
        //posicionActual = transform.position.x;
        //if (posicionActual < posicionUltima)
        //{
        //    transform.localScale = new Vector3(-1, 1, 1);
        //}
        //if (posicionActual > posicionUltima)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
        //}
        //posicionUltima = transform.position.x;
    }

}
