using UnityEngine;

public abstract class AttackState
{
    protected PlayerAttackController PlayerAttackController;
    protected AttackStateMachine AttackStateMachine;
    protected PlayerInput PlayerInput;
    protected Animator Animator;
    protected float Duration;
    protected float FixedTime;
    protected int index;
    protected bool ShouldCombo;
    public AttackState(PlayerAttackController PlayerAttackController,AttackStateMachine AttackStateMachine,PlayerInput PlayerInput,Animator Animator,float Duration,int index)
    {
        this.PlayerAttackController = PlayerAttackController;
        this.AttackStateMachine = AttackStateMachine;
        this.PlayerInput = PlayerInput;
        this.Animator = Animator;
        this.Duration = Duration;
        this.index = index;
    }
    
    public virtual void OnEnter(){}

    public virtual void OnUpdate()
    {
        if (PlayerInput.Player.Attack.triggered)
        {
            ShouldCombo = true;
        }
        FixedTime += Time.deltaTime;
    }
    public virtual void OnExit(){}
}
