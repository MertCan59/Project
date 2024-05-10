using UnityEngine;

public class PlayerRunState : PlayerMovementState
{
    public PlayerRunState(PlayerMovementStateMachine PlayerMovementStateMachine, PlayerMovementController PlayerMovementController, PlayerInput PlayerInput,Rigidbody2D rigidbody,Transform transform,float speed) : base(PlayerMovementStateMachine, PlayerMovementController, PlayerInput)
    {
        this.speed = speed;
        this.rigidbody = rigidbody;
        _transform = transform;
    }

    private bool isFacingRight;
    private Rigidbody2D rigidbody;
    private float speed;
    private Transform _transform;
    
    public override void OnEnter()
    {
        base.OnEnter();
        isFacingRight = true;
        Debug.Log("Entered Run State");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        Flip();
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

    private void Flip()
    {
        if (isFacingRight && Direction.x > 0)
        {
            _transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            isFacingRight = !isFacingRight;
        }
        else if(!isFacingRight && Direction.x < 0)
        {
            _transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            isFacingRight = !isFacingRight;
        }
        
    }
}
