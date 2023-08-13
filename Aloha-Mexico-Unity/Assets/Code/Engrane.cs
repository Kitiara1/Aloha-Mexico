using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engrane : MonoBehaviour
{
    public int indiceImagen;
    private ControladorObjetivos controladorObjetivos;

    private void Start()
    {
        controladorObjetivos = FindObjectOfType<ControladorObjetivos>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && controladorObjetivos != null)
        {
            controladorObjetivos.ActivarObjetivos(indiceImagen);
            gameObject.SetActive(false);
        }
    }
}

