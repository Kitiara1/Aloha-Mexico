using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject escenaInicial;
    public GameObject alien;
    public GameObject alienBack;
    public float velocidadCaminar = 5.0f;
    public float velocidadCorrer = 10.0f;
    public float velocidadActual;
    public float multiplicadorCorrer = 2.0f;
    public float velocidadRotacion = 3.0f;

    private bool juegoIniciado = false;

    private void Start()
    {
        // Desactivar el cursor para permitir el control del personaje.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        velocidadActual = velocidadCaminar;
        alien.SetActive(true);
        alienBack.SetActive(false);
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

            // Movimiento con las teclas AWSD
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");

            Vector3 movimiento = transform.forward * movimientoVertical * velocidadActual +
                                 transform.right * movimientoHorizontal * velocidadActual;

            transform.Translate(movimiento * Time.deltaTime, Space.World);

            // Rotación con el movimiento del mouse
            float rotacionHorizontal = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, rotacionHorizontal * velocidadRotacion);

            // Cambio entre objetos "alien" y "alien_back" según el movimiento
            if (movimiento.magnitude > 0.1f)
            {
                alien.SetActive(false);
                alienBack.SetActive(true);
            }
            else
            {
                alien.SetActive(true);
                alienBack.SetActive(false);
            }
        }
    }
}
