using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador;
    public Vector3 offset;
    public float velocidadSeguimiento = 5.0f;

    private void LateUpdate()
    {
        if (jugador != null)
        {
            Vector3 posicionObjetivo = jugador.position + offset;
            Vector3 posicionInterpolada = Vector3.Lerp(transform.position, posicionObjetivo, velocidadSeguimiento * Time.deltaTime);
            transform.position = posicionInterpolada;

            transform.LookAt(jugador.position);
        }
    }
}
