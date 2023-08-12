using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenaInicialControl : MonoBehaviour
{
    // No se puede mover al inicio
    private bool canMove = false;
    private void Update()
    {
        // Si el usuario presiona una tecla se puede mover
        if (!canMove && Input.anyKeyDown)
        {
            canMove = true;
        }
    }

    // Método para comprobar si el movimiento del personaje está habilitado
    public bool CanMoveCharacter()
    {
        return canMove;
    }
}
