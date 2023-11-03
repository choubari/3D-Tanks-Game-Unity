using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour 
{
    private float movement;
    private float rotation;
    public Rigidbody rigidBody;
    public MeshRenderer[] childs;

    private TankController tankController;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Camera = GameObject.Find("Main Camera");
        Camera.transform.SetParent(transform);
        Camera.transform.position = new Vector3(-42f, 40f, -25f);
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (movement!= 0)
            tankController.Move(movement, tankController.GetTankModel().movement_speed);

        if (rotation!= 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotation_speed);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public TankView()
    {

    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
    public Rigidbody GetRigidBody()
    {
        return rigidBody;
    }
    public void ChangeColor(Material color)
    {
        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].material = color;
        }
    }

}
