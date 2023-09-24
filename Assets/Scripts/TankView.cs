using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Rendering;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    public  Transform turrentRoot;
    public Transform fireTransform;
    public  GameObject projectiblePrefab;
    public ParticleSystem smokeBurstparticle;
    public CinemachineVirtualCamera AdsCamera;
    public CinemachineVirtualCamera followCamera;
    public Volume postProcessVolume;
    [SerializeField] MeshRenderer[] renderers;
    [SerializeField] Rigidbody tankrb;

    float movement;
    float rotation;
    float mouseX;

    float fireInterval;

    
    private void Start()
    {
        SetFollowCamera();
    }

    private void SetFollowCamera()
    {
        followCamera = GameObject.Find("FollowCamera").GetComponent<CinemachineVirtualCamera>();
        followCamera.Follow = turrentRoot;
        followCamera.LookAt = turrentRoot;
        followCamera.Priority = 10;
        AdsCamera.Priority = 0;
    }

    public void Update()
    {
        ProcessInput();
        if (movement != 0)
            tankController.Move(movement,tankController.GetTankModel().movementSpeed);

        if (rotation != 0)
            tankController.Rotate(rotation,tankController.GetTankModel().rotationSpeed);

        if (mouseX != 0)
            tankController.TurnTurret(mouseX, tankController.GetTankModel().turretTurnSpeed);


    }

    public Rigidbody GetRigidbody() => tankrb;

    public void ChangeColor(Material color)
    {
        foreach(MeshRenderer renderer in renderers)
        {
            renderer.material = color;
        }
    }

    private void ProcessInput()
    {
        rotation = Input.GetAxis("Horizontal");
        movement = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");

        fireInterval += Time.deltaTime * tankController.GetTankModel().fireRate;
        if (Input.GetMouseButtonDown(0) && fireInterval >= tankController.GetTankModel().fireRate)
        {
            tankController.Shoot();
            fireInterval = 0;
        }

        if(Input.GetMouseButton(1))
        {
            tankController.ToggleAdsCamera(true);
        }
        else
        {
            tankController.ToggleAdsCamera(false);
        }

    }

    public void SetController(TankController tankController)
    {
        this.tankController = tankController;
    }

}
