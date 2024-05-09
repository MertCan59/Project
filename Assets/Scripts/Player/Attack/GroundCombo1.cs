using UnityEngine;

public class GroundCombo1 : AttackState
{
    public GroundCombo1(PlayerAttackController PlayerAttackController, AttackStateMachine AttackStateMachine, PlayerInput PlayerInput, Animator Animator, float Duration, int index) : base(PlayerAttackController, AttackStateMachine, PlayerInput, Animator, Duration, index)
    {
    }
    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered GC1");
        Animator.SetTrigger("Attack"+index);
        Debug.Log(index);

    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (FixedTime>= Duration)
        {
            if (ShouldCombo)
            {
                AttackStateMachine.ChangeAttackState(PlayerAttackController.GroundCombo2);
            }
            else
            {
                AttackStateMachine.ChangeAttackState(PlayerAttackController.GroundIdle);
            }
        }
    }
    public override void OnExit()
    {
        FixedTime = 0f;
        ShouldCombo = false;

    }
}
