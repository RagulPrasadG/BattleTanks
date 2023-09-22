using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;
    private void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankmodel = new TankModel(10,50);
        TankController tankController = new TankController(tankmodel, tankView);

    }
}
