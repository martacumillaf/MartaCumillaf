using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPerritos : MonoBehaviour
{
    public GameObject perrito;
    
    public float contador;
    public int tiempoAparecerPerritos;

    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoAparecerPerritos)
        {
            Instantiate(perrito, gameObject.transform);
            contador = 0;
        }
    }

    
}
