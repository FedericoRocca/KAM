using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string nombre { get; set; }
    public string detalle { get; set; }
    public float hitPoints { get; set; }
    public UnitState estado { get; set; }
    public Unit()
    {
        nombre = "base";
        detalle = "base";
        hitPoints = 100;
        estado = UnitState.Idle;
    }
}
