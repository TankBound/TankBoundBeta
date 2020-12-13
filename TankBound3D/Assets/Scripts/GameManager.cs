using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    /*
     * provisionalmente seran dos jugadores creados en el editor
     * pero avanzado debera recoger la lista de jugadores en el
     * Aweake.
     */
    public Jugador[] jugadores = new Jugador[2];
    private Jugador jugadorActivo = new Jugador();
    private bool cambioAutorizado = false;

    void Awake()
    {   
        //aqui se debe colocar la llamada para llenar los jugadores
        jugadorActivo = turnoInicialDeJugador();
        Debug.Log("Tu turno jugador: " + jugadorActivo);
        StartCoroutine(controlarCambios());
        
    }   

    private void FixedUpdate()
    {
        if (cambioAutorizado)
        {
            CambiarJugador();
            StartCoroutine(controlarCambios());    
            cambioAutorizado = false;
        }
    }

    private Jugador turnoInicialDeJugador()
    {
        int seleccion = Random.Range(0,1);
        Jugador jT = new Jugador();

        if (seleccion == 0)
        {
            jT = jugadores[0];
        }
        else if (seleccion == 1)
        {
            jT = jugadores[1];
        }
        return jT;
    }

    IEnumerator controlarCambios ()
    {
        Debug.Log("Dispara!!");
        yield return new WaitForSeconds(15);

        Debug.Log("5 SEGUNDOS RESTANTES!!!");
        yield return new WaitForSeconds(5);
        cambioAutorizado = true;
        
    }

    private void CambiarJugador()
    {
        if (jugadorActivo == jugadores[0])
        {
            jugadorActivo = jugadores[1];
            Debug.Log("tu turno jugador: " + jugadorActivo);

        }
        else if (jugadorActivo == jugadores[1])
        {
            jugadorActivo = jugadores[0];
            Debug.Log("tu turno jugador: " + jugadorActivo);

        }
    }

}
