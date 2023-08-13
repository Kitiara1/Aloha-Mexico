using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteraccionSenor : MonoBehaviour
{
    public GameObject uiDialogo;
    public Transform puntoInteraccion;
    public float distanciaInteraccion = 2.0f;
    public TextMeshProUGUI textoDialogo;

    private bool enDialogo = false;
    private int indiceDialogo = 0;
    public string[] dialogo;

    private void Update()
    {
        float distancia = Vector3.Distance(transform.position, puntoInteraccion.position);

        if (!enDialogo && distancia <= distanciaInteraccion && Input.GetKeyDown(KeyCode.E))
        {
            IniciarDialogo();
        }
        else if (enDialogo && Input.GetKeyDown(KeyCode.E))
        {
            MostrarSiguienteDialogo();
        }

        // Si el jugador se aleja, desactiva el diálogo
        if (enDialogo && distancia > distanciaInteraccion)
        {
            FinalizarDialogo();
        }
    }

    private void IniciarDialogo()
    {
        enDialogo = true;
        uiDialogo.SetActive(true);
        MostrarSiguienteDialogo();
    }

    private void MostrarSiguienteDialogo()
    {
        if (indiceDialogo < dialogo.Length)
        {
            textoDialogo.text = dialogo[indiceDialogo];
            indiceDialogo++;
        }
        else
        {
            FinalizarDialogo();
        }
    }

    private void FinalizarDialogo()
    {
        enDialogo = false;
        uiDialogo.SetActive(false);
        indiceDialogo = 0;
    }
}
