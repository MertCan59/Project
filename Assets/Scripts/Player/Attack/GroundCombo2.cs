using UnityEngine;

public class GroundCombo2:AttackState
{
    public GroundCombo2(PlayerAttackController PlayerAttackController, AttackStateMachine AttackStateMachine, PlayerInput PlayerInput, Animator Animator, float Duration, int index) : base(PlayerAttackController, AttackStateMachine, PlayerInput, Animator, Duration, index)
    {
    }
    
    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered GC2");
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
                AttackStateMachine.ChangeAttackState(PlayerAttackController.GroundCombo3);
            }
            else
            {
                AttackStateMachine.ChangeAttackState(PlayerAttackController.GroundIdle);
            }
        }
    }
    public override void OnExit()
    {
        base.OnExit();
        FixedTime = 0f;
        ShouldCombo = false;

    }
}
