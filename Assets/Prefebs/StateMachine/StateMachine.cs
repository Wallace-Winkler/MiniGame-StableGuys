using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private State currentState;
    public string currentStateName {get; private set;}

    public virtual void Update() {
        currentState?.Update();
    } 
    public virtual void LateUpdate() {
        currentState?.LateUpdate();
    } 
    public virtual void FixedUpdate() {
        currentState?.FixedUpdate();
    } 

    public void changeState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentStateName = newState.name;
        newState?.Enter();
    }

}
