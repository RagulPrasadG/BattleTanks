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
                TankModel tankmodelred = new TankModel(tanksList[0].movementSpeed, tanksList[0].rotationSpeed, tanksList[0].color, tanksList[0].fireRate, tanksList[0].projectileForce);
                TankController tankControllerRed = new TankController(tankmodelred, tankView,this.transform.position);
                break;
            case TankTypes.Green:
                TankModel tankmodelgreen = new TankModel(tanksList[1].movementSpeed, tanksList[1].rotationSpeed, tanksList[1].color, tanksList[1].fireRate, tanksList[1].projectileForce);
                TankController tankControllerGreen = new TankController(tankmodelgreen, tankView, this.transform.position);
                break;
            case TankTypes.Blue:
                TankModel tankmodelblue = new TankModel(tanksList[2].movementSpeed, tanksList[2].rotationSpeed, tanksList[2].color, tanksList[2].fireRate, tanksList[2].projectileForce);
                TankController tankControllerBlue = new TankController(tankmodelblue, tankView, this.transform.position);
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
    public float fireRate;
    public float projectileForce;
    public Material color;
}

public enum TankTypes
{
    Red,Green,Blue
}

