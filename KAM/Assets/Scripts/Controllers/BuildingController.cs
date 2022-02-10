using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuildingController : MonoBehaviour
{
    public Building building { get; set; }
    public abstract void processProduction();
}
