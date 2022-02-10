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
        detalle = "Caba�a donde vive el le�ador";
        nombre = "Caba�a del le�ador";
        hitPoints = 100;
        estado = BuildingState.Enabled;
    }
}
