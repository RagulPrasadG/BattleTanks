using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    public bool canFire = true;
    public TankController(TankModel tankModel, TankView tankView,Vector3 Position)
    {
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate(tankView);
        this.tankView.transform.position = Position;
        this.tankView.SetController(this);
        this.tankModel.SetController(this);
        rb = this.tankView.GetRigidbody();
        this.tankView.ChangeColor(this.tankModel.color);

    }

    public TankModel GetTankModel() => tankModel;

    public void Move(float movement,float moveSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * moveSpeed;
        Debug.Log("moving");
    }

    public void TurnTurret(float mouseX,float turnSpeed)
    {
        this.tankView.turrentRoot.eulerAngles = new Vector3(0f, tankView.turrentRoot.eulerAngles.y + mouseX + turnSpeed, 0f);
    }

    public void Shoot()
    {
        Vector3 projectileDirection = tankView.fireTransform.forward;
        GameObject tempProjectile = GameObject.Instantiate(tankView.projectiblePrefab);
        tempProjectile.transform.position = tankView.fireTransform.position;
        tempProjectile.transform.rotation = Quaternion.LookRotation(projectileDirection);
        Rigidbody projectileRb = tempProjectile.GetComponent<Rigidbody>();
        tankView.smokeBurstparticle.Play();
        projectileRb.AddForce(projectileDirection * tankModel.bulletForce);

    }

    public void ToggleAdsCamera(bool toggle)
    {
        if (toggle)
        {
            tankView.AdsCamera.Priority = 10;
            tankView.followCamera.Priority = 0;
            tankView.postProcessVolume.weight = 1;
        }
        else
        {
            tankView.AdsCamera.Priority = 0;
            tankView.followCamera.Priority = 10;
            tankView.postProcessVolume.weight = 0;
        }
            

    }

    public void Rotate(float rotate, float rotationSpeed)
    {
        Debug.Log("rotating");
        float yDeltaRotation = rb.rotation.eulerAngles.y + rotate * rotationSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(new Vector3(0f,yDeltaRotation,0f));
        rb.MoveRotation(rotation);
    }

}
