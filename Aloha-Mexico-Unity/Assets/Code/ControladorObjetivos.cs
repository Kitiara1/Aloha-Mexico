using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorObjetivos : MonoBehaviour
{
    public GameObject objetivos;
    public Image[] imagenesObjetivos;

    public void ActivarObjetivos(int indiceImagen)
    {
        objetivos.SetActive(true);
        imagenesObjetivos[indiceImagen].gameObject.SetActive(true);

        Invoke("DesactivarObjetivos", 2.0f);
    }

    public void DesactivarObjetivos()
    {
        objetivos.SetActive(false);
    }
}

