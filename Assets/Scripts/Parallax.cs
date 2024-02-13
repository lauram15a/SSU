using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float imageWidth;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Vector3 initialPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        direction = new Vector3(-1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CycleController();
    }

    /// <summary>
    /// Cuánto queda de recorrido para alcanzar un nuevo ciclo.
    /// Ciclo = desde el comienzo del BG_0 hasta el final de BG_0(1)
    /// </summary>
    /// <returns></returns>
    private void CycleController()
    {
        float space = speed * Time.time;
        float rest = space % imageWidth;                            // Si he alcanzado un nuevo ciclo, el resto va a ser 0
        transform.position = initialPosition + rest * direction;    // Mi posición se va refrescando desde la inicial sumando tanto como resto quede en la dirección deseada
    }
}
