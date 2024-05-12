using UnityEngine;

public class PlayerRunState : PlayerMovementState
{
    public PlayerRunState(PlayerMovementStateMachine PlayerMovementStateMachine, PlayerMovementController PlayerMovementController, PlayerInput PlayerInput,float speed) : base(PlayerMovementStateMachine, PlayerMovementController, PlayerInput)
    {
        this.speed = speed;

    }

    private bool isFacingRight;
    private float speed;
    private Transform _transform;
    private Rigidbody2D rigidbody;
    
    public override void OnEnter()
    {
        base.OnEnter();
        rigidbody = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
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
