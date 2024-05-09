using System;
using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    private Animator _animator;
    private PlayerInput _playerInput;
    public AttackStateMachine AttackStateMachine;
    public GroundIdle GroundIdle;
    public GroundCombo1 GroundCombo1;
    public GroundCombo2 GroundCombo2;
    public GroundCombo3 GroundCombo3;
    private void Awake()
    {
        _playerInput = new PlayerInput();
        _animator = GetComponent<Animator>();
    }

   private void Start()
    {
        AttackStateMachine = new AttackStateMachine();
        GroundCombo1 = new GroundCombo1(this,AttackStateMachine,_playerInput,_animator,0.5f,1);
        GroundCombo2 = new GroundCombo2(this,AttackStateMachine,_playerInput,_animator,0.5f,2);
        GroundCombo3 = new GroundCombo3(this,AttackStateMachine,_playerInput,_animator,0.75f,3);
        GroundIdle = new GroundIdle(this, AttackStateMachine, _playerInput, _animator, 0, 0);
        AttackStateMachine.StartState(new GroundIdle(this,AttackStateMachine,_playerInput,_animator,0,0));
    }

    private void Update()
    {
        AttackStateMachine.AttackState.OnUpdate();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
}
