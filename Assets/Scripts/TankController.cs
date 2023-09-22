using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate(tankView);
        this.tankView.SetController(this);
        this.tankModel.SetController(this);
        rb = this.tankView.GetRigidbody();

    }

    public TankModel GetTankModel() => tankModel;

    public void Move(float movement,float moveSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * moveSpeed;
        Debug.Log("moving");
    }

    public void Rotate(float rotate, float rotationSpeed)
    {
        Debug.Log("rotating");
        float yDeltaRotation = rb.rotation.eulerAngles.y + rotate * rotationSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(new Vector3(0f,yDeltaRotation,0f));
        rb.MoveRotation(rotation);
    }

}
