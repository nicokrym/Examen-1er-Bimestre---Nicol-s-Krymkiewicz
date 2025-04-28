using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    public int cantidad;
    public float distancia;
    float subprecio;
    float precioFinal;
    string vehiculo;
    bool excede;
    float precioHora;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidad < 100 || cantidad > 10000)
        {
            Debug.Log("Cantidad inválida, mínimo 100kg y máximo 10000kg");
            return;
        }

        if (distancia < 1)
        {
            Debug.Log("Distancia inválida, mínimo 1km");
            return;
        }

        if (cantidad < 2001)
        {
            vehiculo = "Utilitario";
            precioHora = 3000;
        } else if (cantidad < 5001)
        {
            vehiculo = "Pickup";
            precioHora = 4500;
        } else if (cantidad < 10001)
        {
            vehiculo = "Camion";
            precioHora = 7000;
        }

        if (distancia < 50)
        {
            distancia = 50;
        } else if (distancia > 50)
        {
            excede = true;
        }

        if (vehiculo == "Utilitario")
        {
            subprecio = distancia / 25 * 3000;
            if (excede == false)
            {
                precioFinal = subprecio;
            } else if (excede == true)
            {
                precioFinal = subprecio + 3000;
            }
        } else if (vehiculo == "Pickup")
        {
            subprecio = distancia / 25 * 4500;
            if (excede == false)
            {
                precioFinal = subprecio;
            }
            else if (excede == true)
            {
                precioFinal = subprecio + 4500;
            }
        } else if (vehiculo == "Camion")
        {
            subprecio = distancia / 25 * 7000;
            if (excede == false)
            {
                precioFinal = subprecio;
            }
            else if (excede == true)
            {
                precioFinal = subprecio + 7000;
            }
        }

        Debug.Log("Vehiculo necesario: " + vehiculo);
        Debug.Log("Horas necesarias: " + distancia / 25);
        Debug.Log("Precio total: " + distancia / 25 + " horas a " + precioHora + " = " + precioFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
