using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : State<PlayerState>
{


    
    public WalkState(PlayerState stateID, StatesMachine<PlayerState> stateMachine = null) : base(stateID, stateMachine)
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

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
  
    }


    public override void OnExit()
    {
        base.OnExit();
   
    }





}