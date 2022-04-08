//2.Crear las variables necesarias para ingresar por Inspector el precio de 3 productos 
//y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de 
//dinero disponible. Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;
    float productoTotal;
    float dineroExtra;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ingresar el precio del primer producto "+ producto1);
        Debug.Log("Ingresar el precio del segundo producto "+ producto2);
        Debug.Log("Ingresar el precio del tercer producto "+ producto3);
        Debug.Log("Ingresar el monto " + monto);
        productoTotal = producto1 + producto2 + producto3;

        if (productoTotal > monto)
        {
            Debug.Log("Su monto de dinero dispobible es menor al valor de los productos");
            dineroExtra = productoTotal - monto;
            Debug.Log("Falta $" + dineroExtra);
        }
        else if (productoTotal < monto)
        {
            Debug.Log("Su monto de dinero disponible es mayor al valor de los productos");
            dineroExtra = monto - productoTotal;
            Debug.Log("Sobra $" + dineroExtra);
        }
        else if (productoTotal == monto)
        {
            Debug.Log("Alcanzo el dinero exacto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
