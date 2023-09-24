using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Data handling

public class TankModel
{
    private TankController tankController;
    public  float movementSpeed;
    public  float rotationSpeed;
    public float turretTurnSpeed;
    public float fireRate;
    public float bulletForce;
    public Material color;

    public float turretRotation = 0f;
    public TankModel(float movementSpeed, float rotationSpeed, Material material,float fireRate,float bulletForce)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.color = material;
        this.fireRate = fireRate;
        this.bulletForce = bulletForce;
    }


    public void SetController(TankController controller)
    {
        this.tankController = controller;
    }
}
