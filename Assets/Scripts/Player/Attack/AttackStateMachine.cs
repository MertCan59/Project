using UnityEngine;

public class AttackStateMachine
{
    public AttackState AttackState;

    public void StartState(AttackState state)
    {
        AttackState = state;    
        AttackState.OnEnter();
    }

    public void ChangeAttackState(AttackState state)
    {
        AttackState.OnExit();
        AttackState = state;
        AttackState.OnEnter();
    }
}
