using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public List<Tank> tanksList;
    [SerializeField] TankView tankView;
    private void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankmodel = new TankModel(tanksList[0].movementSpeed, tanksList[0].rotationSpeed, tanksList[0].color);
        TankController tankController = new TankController(tankmodel, tankView);

    }
}

[System.Serializable]
public class Tank
{
    public TankTypes tanktype;
    public float movementSpeed;
    public float rotationSpeed;
    public Material color;
}

public enum TankTypes
{
    Red,Green,Blue
}

