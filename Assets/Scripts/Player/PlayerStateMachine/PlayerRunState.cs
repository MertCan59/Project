using UnityEngine;

public class PlayerRunState : PlayerMovementState
{
    public PlayerRunState(PlayerMovementStateMachine PlayerMovementStateMachine, PlayerMovementController PlayerMovementController, PlayerInput PlayerInput,Rigidbody2D rigidbody,float speed) : base(PlayerMovementStateMachine, PlayerMovementController, PlayerInput)
    {
        this.speed = speed;
        this.rigidbody = rigidbody;
    }
    
    private Rigidbody2D rigidbody;
    private float speed;
    
    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered Run State");
    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
        rigidbody.MovePosition(rigidbody.position+Direction*speed*Time.fixedDeltaTime);
    }
    public override void OnExit()
    {
        base.OnExit();
    }
}
