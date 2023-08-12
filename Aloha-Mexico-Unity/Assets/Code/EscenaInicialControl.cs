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
        if (!canMove && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Se ha presionado la tecla Space.");
            canMove = true;
        }
    }

    // Método para comprobar si el movimiento del personaje está habilitado
    public bool CanMoveCharacter()
    {
        Debug.Log(canMove);
        return canMove;
    }
}
