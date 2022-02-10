using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeniadorController : BuildingController
{
    private LeniadorBuilding lBuilding;

    public override void processProduction()
    {
        if( lBuilding.worker != null )
        {
            Debug.Log("Procesamos producción");
            if (lBuilding.estado == BuildingState.Enabled && lBuilding.produccion.Count < 5 && lBuilding.worker.estado == UnitState.Idle)
            {
                Debug.Log("Ponemos a trabajar al leniador");
                lBuilding.worker.estado = UnitState.Working;
            }

            if (lBuilding.estado == BuildingState.Disabled || lBuilding.produccion.Count >= 5)
            {
                Debug.Log("Ponemos a descansar al leniador y actualizamos los items del inventario del edificio");
                lBuilding.worker.estado = UnitState.Idle;
                lBuilding.produccion.Add(new Tronco());
            }
        }
        else
        {
            Debug.Log("No tenemos trabajador en el edificio");
        }
    }

    public void Start()
    {
        lBuilding = new LeniadorBuilding();
    }
    public void Update()
    {
        processProduction();
    }
}
