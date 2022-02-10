using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeniadorBuilding : Building
{
    public List<Item> produccion { get; set; }
    public Leniador worker { get; set; }
    public LeniadorBuilding()
    {
        produccion = new List<Item>();
        detalle = "Cabaña donde vive el leñador";
        nombre = "Cabaña del leñador";
        hitPoints = 100;
        estado = BuildingState.Enabled;
    }
}
