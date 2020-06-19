using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPerritoContrario : MonoBehaviour
{

    public int velocidadPerrito;
    void Update()
    {
        transform.position -= Vector3.left * Time.deltaTime * velocidadPerrito;
        Destroy(gameObject, 5f);
    }
}

