using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    public Rigidbody rigidbody;

    public TankController (TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView); ;
        rigidbody = tankView.GetRigidBody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.color);
    }

    public void Move(float movement, float movement_speed)
    {
        rigidbody.velocity = tankView.transform.forward * movement * movement_speed;
    }
    public void Rotate(float rotation, float rotate_speed)
    {
        Vector3 vector = new Vector3(0f, rotation*rotate_speed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
    }
    public TankModel GetTankModel() 
    {
        return tankModel;
    }
}

