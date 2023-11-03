using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    public float movement_speed;
    public float rotation_speed;
    private TankController tankController;
    public TankTypes tankTypes;
    public Material color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public TankModel(float _movement, float _rotation, TankTypes tank, Material _color)
    {
        movement_speed = _movement;
        rotation_speed = _rotation;
        tankTypes = tank;
        color = _color;
    }

    public void SetTankController (TankController _tankController)
    {
        tankController = _tankController;
    }

    
}
