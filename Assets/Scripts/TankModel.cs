using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Data handling

public class TankModel
{
    private TankController tankController;
    public  float movementSpeed;
    public  float rotationSpeed;
    public Material color;

    public TankModel(float movementSpeed, float rotationSpeed, Material material)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.color = material;   
    }


    public void SetController(TankController controller)
    {
        this.tankController = controller;
    }
}
