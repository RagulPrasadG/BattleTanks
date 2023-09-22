using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    public void SetController(TankController tankController)
    {
        this.tankController = tankController;
    }

 
}
