using UnityEngine;

public class GroundIdle : AttackState
{
    public GroundIdle(PlayerAttackController PlayerAttackController, AttackStateMachine AttackStateMachine, PlayerInput PlayerInput, Animator Animator, float Duration, int index) : base(PlayerAttackController, AttackStateMachine, PlayerInput, Animator, Duration, index)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered GI");
        ShouldCombo = false;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (ShouldCombo)
        {
            AttackStateMachine.ChangeAttackState(PlayerAttackController.GroundCombo1);
        }
    }

    public override void OnExit()
    {
        base.OnExit();
        FixedTime = 0f;
    }
}
