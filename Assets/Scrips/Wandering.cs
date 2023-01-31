using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour
{

    public Transform[] wayPoint;

    public float speed; // se define su velocidad 
    public float range; // el rango en el cual se ira moviendo aleatoriamente
    public float maxDistance; // su distancia maxima, para que no avandone su sitio

    //public GameObject puntoA, puntoB, puntoC; <- Buscaba sacar su vector, aunque al momento de programarlo no me funcionaba.
    int i = 0; // se crea un index para buscar los puntos 


    //Vector2 wayPoint; // se utiliza como ejemplo de como funciona 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoint[i].transform.position; // empieza a ir al primer waypoint 

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, waypoints, speed * Time.deltaTime);   Esta funcion sirve para que se muevan entre un lugar a otro ejemplo de 
        // de como funcionan
        Move(); // comienza a moverse


    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,
                                                wayPoint[i].transform.position,
                                                speed * Time.deltaTime); // busca en el index de los waypoint y comienza a moverse a una valocidad puesta por nosotros

        if (transform.position == wayPoint[i].transform.position) // si la posicion de la IA es igual a la del waypoint buscara el siguiente 
        {
            i += 1; // aumenta el index para cambiar el waypoint
            
        }

        if (i == wayPoint.Length)
        {
            i = 0; // si el index es igual al numero de waypoint estos se resetearan y regresara a su inicio.
        }
            
    }



    //https://www.youtube.com/watch?v=FdNervYWmcE&t=96s&ab_channel=PekkeDev este video me ayudo mas a programar la forma en la que esto se realiza, pues tenia una idea 
    // aunque unicamente se podia con 3D
    // https://www.youtube.com/watch?v=ExRQAEm4jPg&ab_channel=AlexanderZotov videos para entender como poner mas de un waypoint y que valla cambiando entre elos
}
