using UnityEngine;

public abstract class PlayerMovementState
{
    protected PlayerMovementStateMachine PlayerMovementStateMachine;
    protected PlayerMovementController PlayerMovementController;
    private readonly PlayerInput PlayerInput;
    protected Vector2 Direction;
    protected bool Jump;

    public PlayerMovementState(PlayerMovementStateMachine PlayerMovementStateMachine,
        PlayerMovementController PlayerMovementController, PlayerInput PlayerInput)
    {
        this.PlayerMovementStateMachine = PlayerMovementStateMachine;
        this.PlayerMovementController = PlayerMovementController;
        this.PlayerInput = PlayerInput;
    }

    public virtual void OnEnter()
    {
        
    }

    public virtual void OnUpdate()
    {
        Direction = PlayerInput.Player.Move.ReadValue<Vector2>();
        if (PlayerInput.Player.Jump.triggered)
        {
            Jump = true;
        }
        else
        {
            Jump = false;
        }
    }
    public virtual void OnFixedUpdate(){}
    public virtual void OnExit(){}
}
