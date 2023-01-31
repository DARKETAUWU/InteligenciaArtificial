using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour
{

    public Transform[] wayPoint;

    public float speed; // se define su velocidad 
    public float range; // el rango en el cual se ira moviendo aleatoriamente
    public float maxDistance; // su distancia maxima, para que no avandone su sitio

    public GameObject puntoA, puntoB, puntoC;
    int i = 0; // se crea un index para buscar los puntos 


    //Vector2 wayPoint; // se utiliza como ejemplo de como funciona 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoint[i].transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, waypoints, speed * Time.deltaTime);   Esta funcion sirve para que se muevan entre un lugar a otro ejemplo de 
        // de como funcionan
        Move();


    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,
                                                wayPoint[i].transform.position,
                                                speed * Time.deltaTime);

        if (transform.position == wayPoint[i].transform.position)
        {
            i += 1;
            
        }

        if (i == wayPoint.Length)
        {
            i = 0;
        }
            
    }

    void apagartodo() // apaga los monitos
    {
       
    }

    //https://www.youtube.com/watch?v=FdNervYWmcE&t=96s&ab_channel=PekkeDev este video me ayudo mas a programar la forma en la que esto se realiza, pues tenia una idea 
    // aunque unicamente se podia con 3D
}
