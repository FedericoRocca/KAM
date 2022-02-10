using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tronco : Item
{
    public Tronco()
    {
        nombre = "Tronco";
        detalle = "El tronco de un arbol recientemente cortado";
        estado = ItemState.Idle;
    }
}
