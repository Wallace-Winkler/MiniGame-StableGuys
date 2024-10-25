using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private StateMachine stateMachine;
    public Idle stateIdle;
    public Moving stateMoving;

    [HideInInspector] public Vector2 movimentVector;

    void Start()
    {
        stateMachine = new StateMachine();
        stateIdle = new Idle(this);
        stateMoving = new Moving(this);
        stateMachine.changeState(stateMoving);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move() {
        var isUp = Input.GetKey(KeyCode.W);
        var isDown = Input.GetKey(KeyCode.S);
        var isRight = Input.GetKey(KeyCode.D);
        var isLeft = Input.GetKey(KeyCode.A);

        var inputX = isRight ? 1 : isLeft ? -1 : 0;
        var inputY = isUp ? 1 : isDown ? -1 : 0;

        movimentVector = new Vector2(inputX, inputY);

        stateMachine.Update();
    }
}
