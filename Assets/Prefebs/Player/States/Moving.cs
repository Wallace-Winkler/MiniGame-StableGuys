using UnityEngine;

public class Moving : State
{

    private PlayerController controller;

    public Moving(PlayerController controller) : base("Moving")
    {
        this.controller = controller;
    }

     public override void Enter()
    {
        base.Enter();

        Debug.Log("Entrou no moving");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Saiu do moving");
    }

    public override void Update()
    {
        base.Update();

        if (Input.GetKey(KeyCode.W))
        {
            controller.transform.position += new Vector3(0, 0, controller.speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            controller.transform.position += new Vector3(-controller.speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            controller.transform.position += new Vector3(0, 0, -controller.speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            controller.transform.position += new Vector3(controller.speed, 0, 0) * Time.deltaTime;
        }
    }

    public override void LateUpdate()
    {
        base.LateUpdate();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}