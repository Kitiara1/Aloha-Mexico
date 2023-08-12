using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // velocidad de movimiento
    private EscenaInicialControl escenaInicialControl;

    private void Start()
    {
        // Obtener la referencia al script de control de la pantalla de inicio
        escenaInicialControl = FindObjectOfType<EscenaInicialControl>();
    }

    private void Update()
    {
        // Verificar si el movimiento del personaje está habilitado
        if (escenaInicialControl.CanMoveCharacter())
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;

            transform.Translate(movement);
        }
    }
}
