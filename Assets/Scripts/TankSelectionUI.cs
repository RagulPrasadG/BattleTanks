using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelectionUI : MonoBehaviour
{
    [SerializeField] TankSpawner tankSpawner;
    public void OnBlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.Blue);
        this.gameObject.SetActive(false);
    }

    public void OnGreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.Green);
        this.gameObject.SetActive(false);
    }

    public void OnRedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.Red);
        this.gameObject.SetActive(false);
    }

}
