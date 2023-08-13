using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorHUD : MonoBehaviour
{
    public GameObject hud;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Se ha presionado la tecla Tabulador.");
            hud.SetActive(!hud.activeSelf);
        }
    }
}
