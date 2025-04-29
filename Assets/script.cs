using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public string patente;
    public int anioFabricacion;
    public int kilometrosRecorridos;
    public int vencimientoVtv;
    public float HCppm;

    void Start()
    {
        if (patente == "")
        {
            Debug.Log("No se ingreso la patente, VTV no aprobada");
            return;
        }
        if (anioFabricacion < 1900 || anioFabricacion > 2025)
        {
            Debug.Log("Anio de fabricacion no valido, VTV no aprobada");
            return;
        }
        if (kilometrosRecorridos < 0)
        {
            Debug.Log("Los kilometros recorridos no puden ser negativos, VTV no aprobada");
            return;
        }
        if (vencimientoVtv < anioFabricacion || vencimientoVtv > 2025)
        {
            Debug.Log("Fecha de vencimiento de la VTV actual no es valida, VTV no aprobada");
            return;
        }
        if (HCppm < 5)
        {
            Debug.Log("HCppm no valido, debe ser mayor o igual a 5, VTV no aprobada");
            return;
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
