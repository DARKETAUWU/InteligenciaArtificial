using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour
{

    public Transform[] wayPoint;

    public float fMaxspeed; // se define su velocidad 
    public float frange; // el rango en el cual se ira moviendo aleatoriamente
    public float maxDistance; // su distancia maxima, para que no avandone su sitio

    //public GameObject puntoA, puntoB, puntoC; <- Buscaba sacar su vector, aunque al momento de programarlo no me funcionaba.
    int i = 0; // se crea un index para buscar los puntos 

    Vector2 velocity = Vector2.zero;

    //Vector2 wayPoint; // se utiliza como ejemplo de como funciona 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoint[i].transform.position; // empieza a ir al primer waypoint 

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, wayoints, speed * Time.deltaTime);   Esta funcion sirve para que se muevan entre un lugar a otro ejemplo de 
        // de como funcionan
        
        Move(); // comienza a moverse


    }

    void Move()
    {
        Vector2 waintpoints = wayPoint[i].position; // primeramente tenemos que inizalizar el waint point con la posicion 
        Vector2 playerDistance = (waintpoints - (Vector2)transform.position); // calcula la distancia con la cual se encuentra la posicion del jugador 
        Vector2 disredVelocity = playerDistance.normalized * fMaxspeed; // Calcula la velocidad con la distancia para que tenga la mayor velocidad a utilizar
        Vector2 streering = disredVelocity - velocity; 
        velocity += streering * Time.deltaTime; // Cambia su velocidad a lo largo del tiempo

        transform.position += (Vector3)velocity * Time.deltaTime; // Mueve al personaje con su velocidad a lo largo del tiempo
        //transform.position = Vector2.MoveTowards(transform.position,
        //                                        wayPoint[i].transform.position,
        //                                       velocity * Time.deltaTime); // busca en el index de los waypoint y comienza a moverse a una valocidad puesta por nosotros
        
        if (transform.position == wayPoint[i].position) // si la posicion de la IA es igual a la del waypoint buscara el siguiente 
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
