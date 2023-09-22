using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = tankView;
        tankModel.SetController(this);
        tankView.SetController(this);
        GameObject.Instantiate(this.tankView);
    }


}
