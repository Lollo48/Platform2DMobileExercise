using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State<PlayerState>
{

    public IdleState(PlayerState playerState, StatesMachine<PlayerState> stateManager = null) : base(playerState, stateManager)
    {
       
    }


    public override void OnEnter()
    {
        base.OnEnter();

        
    }


    public override void OnUpdate()
    {
        base.OnUpdate();



    }




    public override void OnExit()
    {
        base.OnExit();
        
    }

}