using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPerrito : MonoBehaviour
{

    public int velocidadPerrito;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * velocidadPerrito;
        Destroy(gameObject, 5f);
    }
}
