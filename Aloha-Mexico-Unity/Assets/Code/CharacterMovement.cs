using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject escenaInicial;
    public float velocidadCaminar = 5.0f;
    public float velocidadCorrer = 10.0f;
    public float velocidadActual;
    public float multiplicadorCorrer = 2.0f;

    private bool juegoIniciado = false;

    private void Start()
    {
        // Desactivar el cursor para permitir el control del personaje.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        velocidadActual = velocidadCaminar;
    }

    private void Update()
    {
        if (!juegoIniciado)
        {
            if (Input.anyKeyDown)
            {
                escenaInicial.SetActive(false);
                juegoIniciado = true;
            }
        }

        if (juegoIniciado)
        {
            // Verificar si el jugador quiere correr.
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                velocidadActual = velocidadCorrer;
            }
            else
            {
                velocidadActual = velocidadCaminar;
            }

            // Obtener las entradas de movimiento del jugador.
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");

            // Calcular la dirección del movimiento.
            Vector3 movimiento = transform.right * movimientoHorizontal + transform.forward * movimientoVertical;

            // Aplicar el movimiento al personaje.
            transform.Translate(movimiento * velocidadActual * Time.deltaTime);
        }
    }
}
