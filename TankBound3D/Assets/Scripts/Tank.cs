using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    Transform posicion;
    int vida;

    private void Start()
    {
        posicion = GetComponent<Transform>();
        vida = 100;
    }

}
