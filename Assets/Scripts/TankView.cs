using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    [SerializeField] Rigidbody rb;

    float movement;
    float rotation;
    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.localPosition = new Vector3(0f, 3f, -4f);
    }
    public void Update()
    {
        ProcessInput();
        if (movement != 0)
            tankController.Move(movement,tankController.GetTankModel().movementSpeed);

        if (rotation != 0)
            tankController.Rotate(rotation,tankController.GetTankModel().rotationSpeed);
           
    }

    public Rigidbody GetRigidbody() => rb;

    private void ProcessInput()
    {
        rotation = Input.GetAxis("Horizontal");
        movement = Input.GetAxis("Vertical");
    }

    public void SetController(TankController tankController)
    {
        this.tankController = tankController;
    }

}
