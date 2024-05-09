using UnityEngine;

public class GroundCombo3 : AttackState
{
    public GroundCombo3(PlayerAttackController PlayerAttackController, AttackStateMachine AttackStateMachine, PlayerInput PlayerInput, Animator Animator, float Duration, int index) : base(PlayerAttackController, AttackStateMachine, PlayerInput, Animator, Duration, index)
    {
    }
    
    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered GC3");
        Animator.SetTrigger("Attack"+index);
        Debug.Log(index);
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (FixedTime>= Duration)
        {
            AttackStateMachine.ChangeAttackState(PlayerAttackController.GroundIdle);
            
        }
    }
    public override void OnExit()
    {
        FixedTime = 0f;
    }
}
