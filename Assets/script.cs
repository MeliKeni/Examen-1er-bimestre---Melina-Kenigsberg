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
    bool aprobado = true;
    int aniosAuto = 0;
    float promedioKilometraje =0; 
    void Start()
    {
        if (patente == "")
        {
            Debug.Log("No se ingreso la patente");
            aprobado = false;
            
        }
        if (anioFabricacion < 1900 || anioFabricacion > 2025)
        {
            Debug.Log("Anio de fabricacion no valido");
            aprobado = false;
        }
        if (kilometrosRecorridos < 0)
        {
            Debug.Log("Los kilometros recorridos no puden ser negativos");
            aprobado = false;
        }
        if (vencimientoVtv <= anioFabricacion || vencimientoVtv >= 2025)
        {
            Debug.Log("Fecha de vencimiento de la VTV actual no es valida");
            aprobado = false;
        }
        if (HCppm < 5)
        {
            Debug.Log("HCppm no valido, debe ser mayor o igual a 5");
            aprobado = false;
        }

        if(HCppm > 100)
        {
            aprobado = false;
        }
        if (aprobado == false)
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        aniosAuto = 2025 - anioFabricacion;
        promedioKilometraje = kilometrosRecorridos / aniosAuto;

        if(promedioKilometraje < 10000)
        {
            Debug.Log("VTV otorgada por 2 años");
        }else
        {
            Debug.Log("VTV otorgada por 1 año");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
