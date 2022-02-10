using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public string nombre { get; set; }
    public string detalle { get; set; }
    public float hitPoints { get; set; }
    public BuildingState estado { get; set; }
    public Building()
    {
        nombre = "base";
        detalle = "base";
        hitPoints = 100;
        estado = BuildingState.Enabled;
    }
}
