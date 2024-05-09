using UnityEngine;

public class PlayerMovementStateMachine
{
    public PlayerMovementState CurrentPlayerMovementState { get; private set; }

    public void StartState(PlayerMovementState PlayerMovementState)
    {
        CurrentPlayerMovementState = PlayerMovementState;
        CurrentPlayerMovementState.OnEnter();
    }

    public void ChangePlayerState(PlayerMovementState state)
    {
        CurrentPlayerMovementState.OnExit();
        CurrentPlayerMovementState = state;
        CurrentPlayerMovementState.OnEnter();
    }
}
