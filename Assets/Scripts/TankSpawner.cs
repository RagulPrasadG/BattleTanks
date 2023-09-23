using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public List<Tank> tanksList;
    [SerializeField] TankView tankView;

    public void CreateTank(TankTypes tankType)
    {
        switch (tankType)
        {
            case TankTypes.Red:
                TankModel tankmodelred = new TankModel(tanksList[0].movementSpeed, tanksList[0].rotationSpeed, tanksList[0].color);
                TankController tankControllerRed = new TankController(tankmodelred, tankView);
                break;
            case TankTypes.Green:
                TankModel tankmodelgreen = new TankModel(tanksList[1].movementSpeed, tanksList[1].rotationSpeed, tanksList[1].color);
                TankController tankControllerGreen = new TankController(tankmodelgreen, tankView);
                break;
            case TankTypes.Blue:
                TankModel tankmodelblue = new TankModel(tanksList[2].movementSpeed, tanksList[2].rotationSpeed, tanksList[2].color);
                TankController tankControllerBlue = new TankController(tankmodelblue, tankView);
                break;
        }
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

