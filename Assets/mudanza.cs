using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudanza : MonoBehaviour
{
    // Start is called before the first frame update
    public int kilosATransportar;
    public int kilometrosARecorrer;
    int kmPorHora = 25;
    int kmDeHoraExtra = 50;
    int capacidadUtilitario = 2000;
    int capacidadPickup = 5000;
    int capacidadCamion = 10000;
    int precioUtilitario = 3000;
    int precioPickup = 4500;
    int precioCamion = 7000;
    
    void Start()
    {
        if(kilometrosARecorrer < 1 || kilosATransportar < 100 || kilosATransportar > capacidadCamion || kilosATransportar < 1)
        {
            Debug.Log("Cantidad de kilos o kilómetros inadecuadados, por favor, ingrese las unidades de nuevo");
        }
        else
        {
            int vehiculoPrecio = precioUtilitario;
            string vehiculo = "Utilitario";
            float precioTotal;
            if(kilosATransportar > capacidadUtilitario && kilosATransportar <= capacidadPickup)
            {
                vehiculoPrecio = precioPickup;
                vehiculo = "PickUp";
            } else if(kilosATransportar >= capacidadPickup)
            {
                vehiculoPrecio = precioCamion;
                vehiculo = "Camión";
            }
            Debug.Log("Se uso un " + vehiculo);
            float duracion = (float)kilometrosARecorrer / (float)kmPorHora;
            if(duracion <= 2)
            {
                precioTotal = (float)vehiculoPrecio * 2;
            }
            else
            {
                precioTotal = (float)vehiculoPrecio * duracion;
            }
            if (kilometrosARecorrer > kmDeHoraExtra)
            {
                precioTotal = precioTotal + (float)vehiculoPrecio;
                duracion = duracion + 1;
            }
            Debug.Log("El precio total es " + duracion + " horas a " + vehiculoPrecio + " pesos por hora:");
            Debug.Log(precioTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
