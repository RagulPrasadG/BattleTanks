using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Data handling

public class TankModel
{
    private TankController tankController;
    public  float movementSpeed;
    public  float rotationSpeed;
    public TankModel(float movementSpeed, float rotationSpeed)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
    }


    public void SetController(TankController controller)
    {
        this.tankController = controller;
    }
}
